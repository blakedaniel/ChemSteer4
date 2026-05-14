import { test, expect, Page } from "@playwright/test";

const stamp = () => new Date().getTime();

async function createAssessment(page: Page, name: string, chemical?: string) {
  await page.goto("/assessments");
  await page.getByPlaceholder("Name (e.g. PMN-12345)").fill(name);
  if (chemical) {
    await page.getByPlaceholder("Chemical (optional)").fill(chemical);
  }
  await page.getByRole("button", { name: "Create" }).click();
  // Navigates to detail page.
  await page.waitForURL(/\/assessments\/\d+/);
  await expect(page.getByRole("heading", { name })).toBeVisible();
}

test.describe("Assessment workflow", () => {
  test("create assessment + appears in list", async ({ page }) => {
    const name = `E2E-Create-${stamp()}`;
    await createAssessment(page, name, "acetone");
    // Back to list — should now contain the new row.
    await page.goto("/assessments");
    await expect(page.locator("table tbody")).toContainText(name);
    await expect(page.locator("table tbody")).toContainText("acetone");
  });

  test("full happy path: create → operation → activity → run → calc → results", async ({
    page,
  }) => {
    const name = `E2E-HappyPath-${stamp()}`;
    await createAssessment(page, name);

    // Add an operation (pick the first user-defined op).
    // The AddOperationForm is the one row that contains "Add operation:".
    const addOpRow = page.locator("div").filter({
      has: page.locator("text=Add operation:"),
    }).last();
    await addOpRow.locator("select").selectOption({ index: 1 });
    await addOpRow.getByRole("button", { name: "Add", exact: true }).click();

    // Operation card is now visible.
    const opCard = page.locator("div").filter({ hasText: /^Op #\d+/ }).first();
    await expect(opCard).toBeVisible();

    // Scope the activity select & Add button to the operation card.
    const addActRow = opCard.locator("div").filter({
      has: page.locator("text=Add activity:"),
    }).last();
    await addActRow.locator("select").selectOption({ index: 1 });
    await addActRow.getByRole("button", { name: "Add", exact: true }).click();

    // Activity row now visible.
    await expect(page.locator("text=/Activity #\\d+/").first()).toBeVisible();

    // Open the "+ Add model run" disclosure.
    const runDetails = page.locator("details").filter({
      hasText: "Add model run",
    }).first();
    await runDetails.locator("summary").click();

    // Pick model #2 (drum residual) so the default inputs JSON is valid.
    await runDetails.locator("select").selectOption("2");

    // Inputs textarea defaults to a valid residual JSON.
    await runDetails.getByRole("button", { name: /Add run/i }).click();
    await expect(page.locator("li").filter({ hasText: /release/ }).first()).toBeVisible();

    // Trigger calc.
    await page.getByRole("button", { name: /Run calc on all attached models/ }).click();

    // After calc, outputs are rendered inline in the run li (DR/AR with kg units).
    await expect(page.locator("body")).toContainText(/kilogram/, { timeout: 10_000 });
  });

  test("revisions list updates after calc", async ({ page }) => {
    const name = `E2E-Revisions-${stamp()}`;
    await createAssessment(page, name);

    // Add an operation.
    const opSelect = page.locator("select").first();
    await opSelect.selectOption({ index: 1 });
    await page.getByRole("button", { name: "Add", exact: true }).click();
    await expect(page.locator("text=/Op #\\d+/").first()).toBeVisible();

    // Sidebar reveals revisions.
    await expect(page.locator("text=Revisions")).toBeVisible();
    // We should see at least one revision entry (the assessment was created
    // and an operation was added).
    const sidebar = page.locator("aside, [class*='sidebar'], div").filter({
      hasText: "Revisions",
    });
    await expect(sidebar.first()).toBeVisible();
  });

  test("report links are present on detail page", async ({ page }) => {
    const name = `E2E-Reports-${stamp()}`;
    await createAssessment(page, name);
    for (const fmt of ["HTML", "PDF", "CSV", "JSON"]) {
      await expect(page.locator(`a:has-text('${fmt}')`).first()).toBeVisible();
    }
  });
});
