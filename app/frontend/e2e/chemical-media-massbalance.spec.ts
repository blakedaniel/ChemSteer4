import { test, expect, Page } from "@playwright/test";

const stamp = () => new Date().getTime();

async function createAssessment(page: Page, name: string) {
  await page.goto("/assessments");
  await page.getByPlaceholder("Name (e.g. PMN-12345)").fill(name);
  await page.getByRole("button", { name: "Create" }).click();
  await page.waitForURL(/\/assessments\/\d+/);
  await expect(page.getByRole("heading", { name })).toBeVisible();
}

test.describe("Chemical record", () => {
  test("save chemical properties → VP/MW prefill model defaults", async ({
    page,
  }) => {
    await createAssessment(page, `E2E-Chem-${stamp()}`);

    const form = page.getByTestId("chemical-form");
    await form.locator("summary").click();
    await form.getByLabel(/Molecular weight/).fill("72.1");
    await form.getByLabel(/Vapor pressure/).fill("10");
    await form.getByRole("button", { name: "Save chemical" }).click();
    await expect(form.getByText("saved ✓")).toBeVisible();

    // Plain operation + activity, then pick Mass Balance (#22): the
    // prefill must include the chemical record's VP and MW.
    const addOpRow = page
      .locator("div")
      .filter({ has: page.locator("text=Add operation:") })
      .last();
    await addOpRow.locator("select").selectOption({ index: 1 });
    await addOpRow.getByRole("button", { name: "Add", exact: true }).click();
    const addActRow = page
      .locator("div")
      .filter({ has: page.locator("text=Add activity:") })
      .last();
    await addActRow.locator("select").selectOption({ index: 1 });
    await addActRow.getByRole("button", { name: "Add", exact: true }).click();

    const runDetails = page
      .locator("details")
      .filter({ hasText: "Add model run" })
      .first();
    await runDetails.locator("summary").click();
    await runDetails.locator("select").selectOption("22");

    const textarea = runDetails.locator("textarea");
    await expect(textarea).toHaveValue(/"VP": 10/);
    await expect(textarea).toHaveValue(/"MW": 72\.1/);
    await expect(textarea).toHaveValue(/"k": 0\.5/); // CT mixing factor
  });
});

test.describe("Mass balance solver", () => {
  test("NS+OD+Yprod knowns derive DMOchem and DMOprod", async ({ page }) => {
    await createAssessment(page, `E2E-MB-${stamp()}`);

    const panel = page.getByTestId("mass-balance");
    await panel.locator("summary").click();
    await panel.getByLabel(/Production volume/).fill("500000");
    await panel.getByLabel(/Number of sites/).fill("2");
    await panel.getByLabel(/Operating days/).fill("250");
    await panel.getByLabel(/Weight fraction in product/).fill("0.5");
    await panel.getByRole("button", { name: "Solve" }).click();

    const result = page.getByTestId("mass-balance-result");
    await expect(result).toContainText("DMOchem = 1.000e+3");
    await expect(result).toContainText("DMOprod = 2.000e+3");
    await expect(result).toContainText("derived: DMOchem, DMOprod");
  });
});

test.describe("Release media partitioning", () => {
  test("scenario runs ship MediaDefaults; split is editable", async ({
    page,
  }) => {
    await createAssessment(page, `E2E-Media-${stamp()}`);

    const gsRow = page.getByTestId("add-from-scenario");
    await gsRow
      .locator("select")
      .selectOption({ label: "Use: Recirculating Water-Cooling Tower Additive (non-volatile)" });
    await gsRow.getByRole("button", { name: "Use scenario" }).click();

    const blowdownRow = page.locator("li").filter({ hasText: "#12 release" });
    await expect(blowdownRow).toBeVisible();
    // Blowdown defaults to 100 % Water (MediaDefaults model 12 → MediaID 13).
    await expect(blowdownRow).toContainText("Water 100%");
    const windageRow = page.locator("li").filter({ hasText: "#13 release" });
    await expect(windageRow).toContainText("Air 100%");

    // Repartition blowdown 60 % Water / 40 % Landfill. (Rows reorder by
    // numeric MediaID, so target the spinbuttons by their medium name.)
    await blowdownRow.getByRole("button", { name: "media", exact: true }).click();
    const editor = blowdownRow.getByTestId("media-editor");
    await editor.getByRole("spinbutton", { name: /Water/ }).fill("60");
    await expect(editor).toContainText("total 60.0 %");
    await editor.locator("select").selectOption({ label: "Landfill" });
    await editor.getByRole("button", { name: "add" }).click();
    await editor.getByRole("spinbutton", { name: /Landfill/ }).fill("40");
    await expect(editor).toContainText("total 100.0 %");
    await editor.getByRole("button", { name: "Save media" }).click();

    await expect(blowdownRow).toContainText("Water 60%");
    await expect(blowdownRow).toContainText("Landfill 40%");
  });
});
