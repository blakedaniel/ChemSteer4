import { test, expect, Page } from "@playwright/test";

const stamp = () => new Date().getTime();

async function createAssessment(page: Page, name: string) {
  await page.goto("/assessments");
  await page.getByPlaceholder("Name (e.g. PMN-12345)").fill(name);
  await page.getByRole("button", { name: "Create" }).click();
  await page.waitForURL(/\/assessments\/\d+/);
  await expect(page.getByRole("heading", { name })).toBeVisible();
}

test.describe("Generic Scenario instantiation", () => {
  test("add cooling-tower scenario → pre-parameterized runs appear", async ({
    page,
  }) => {
    await createAssessment(page, `E2E-GS-${stamp()}`);

    const gsRow = page.getByTestId("add-from-scenario");
    await gsRow
      .locator("select")
      .selectOption({ label: "Use: Recirculating Water-Cooling Tower Additive (non-volatile)" });
    await gsRow.getByRole("button", { name: "Use scenario" }).click();

    // Success banner with counts.
    await expect(page.locator("body")).toContainText(
      /pre-parameterized model runs/,
    );

    // The operation + activity + runs render; blowdown (#12) and windage
    // (#13) come from the activity's default models with derived DRRchem.
    await expect(page.locator("body")).toContainText(
      "Recirculating Water-Cooling Tower Additive Releases",
    );
    await expect(page.locator("li").filter({ hasText: "#12 release" })).toBeVisible();
    await expect(page.locator("li").filter({ hasText: "#13 release" })).toBeVisible();
    await expect(page.locator("body")).toContainText(/"Amt":10900\.8/);
  });

  test("edit a scenario run's inputs and calc it", async ({ page }) => {
    await createAssessment(page, `E2E-GS-Edit-${stamp()}`);

    const gsRow = page.getByTestId("add-from-scenario");
    await gsRow
      .locator("select")
      .selectOption({ label: "Use: Recirculating Water-Cooling Tower Additive (non-volatile)" });
    await gsRow.getByRole("button", { name: "Use scenario" }).click();
    await expect(page.locator("li").filter({ hasText: "#12 release" })).toBeVisible();

    // Complete the blowdown run (NS is user-input, like v3.2).
    const blowdownRow = page.locator("li").filter({ hasText: "#12 release" });
    await blowdownRow.getByRole("button", { name: "edit" }).click();
    const editArea = blowdownRow.locator("textarea");
    const current = JSON.parse(await editArea.inputValue());
    await editArea.fill(JSON.stringify({ ...current, NS: 1 }));
    await blowdownRow.getByRole("button", { name: "Save inputs" }).click();
    await expect(blowdownRow.locator("code")).toContainText('"NS":1');

    // Calc: blowdown computes; windage still lacks NS and reports an error.
    await page
      .getByRole("button", { name: /Run calc on all attached models/ })
      .click();
    await expect(page.locator("body")).toContainText(/DR = 6\.540e\+1/, {
      timeout: 10_000,
    });
    // 65.4 kg/site-day = DRRchem 10,900.8 × LFb 0.006 — matches the GS
    // defaults end-to-end. Windage still lacks NS → reported as failed.
    await expect(page.locator("body")).toContainText(/1 ok, 1 failed/);
  });
});

test.describe("Defaults prefill", () => {
  test("picking the 2-hand dermal model pre-fills S=1070 and BW=70", async ({
    page,
  }) => {
    await createAssessment(page, `E2E-Defaults-${stamp()}`);

    // Plain operation + activity.
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
    await runDetails.locator("select").selectOption("26");

    const textarea = runDetails.locator("textarea");
    await expect(textarea).toHaveValue(/"S": 1070/);
    await expect(textarea).toHaveValue(/"BW": 70/);
    await expect(textarea).toHaveValue(/"Qu": null/); // sentinel → user input
  });
});

test.describe("Reference lookups", () => {
  test("NAICS search", async ({ page }) => {
    await page.goto("/reference");
    await page
      .getByPlaceholder(/Code prefix or description/)
      .fill("325");
    await expect(page.locator("table").first()).toContainText("Chemical", {
      timeout: 5_000,
    });
  });

  test("exposure-limit search by name", async ({ page }) => {
    await page.goto("/reference");
    await page
      .getByPlaceholder(/CAS number or chemical name/)
      .fill("LINDANE");
    const limitsTable = page.locator("table").nth(1);
    await expect(limitsTable).toContainText("58-89-9", { timeout: 5_000 });
    await expect(limitsTable).toContainText("0.5");
  });
});
