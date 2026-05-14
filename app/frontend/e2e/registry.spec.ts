import { test, expect } from "@playwright/test";

// Fail any test that produces an uncaught JS console error or pageerror.
test.beforeEach(async ({ page }) => {
  const errors: string[] = [];
  page.on("pageerror", (e) => errors.push(`pageerror: ${e.message}`));
  page.on("console", (msg) => {
    if (msg.type() === "error") errors.push(`console.error: ${msg.text()}`);
  });
  (test.info() as unknown as { _errors: string[] })._errors = errors;
});

test.afterEach(async () => {
  const errors = (test.info() as unknown as { _errors: string[] })._errors ?? [];
  // Allow expected favicon 404s; otherwise fail.
  const real = errors.filter((e) => !/favicon|MIME type/.test(e));
  expect(real, `JS errors: ${real.join(" | ")}`).toEqual([]);
});

test.describe("Registry browse pages", () => {
  test("home redirects to /assessments", async ({ page }) => {
    await page.goto("/");
    await expect(page).toHaveURL(/\/assessments$/);
    await expect(page.getByRole("heading", { name: "Assessments" })).toBeVisible();
  });

  test("Models page lists registry + filters", async ({ page }) => {
    await page.goto("/models");
    await expect(page.getByRole("heading", { name: "Models" })).toBeVisible();
    // Wait for first row to render.
    await expect(page.locator("table tbody tr").first()).toBeVisible();
    // Filter to Release only — table should still contain rows.
    await page.getByRole("button", { name: "R", exact: true }).click();
    await expect(page.locator("table tbody tr").first()).toBeVisible();
    // Inhalation
    await page.getByRole("button", { name: "I", exact: true }).click();
    await expect(page.locator("table tbody tr").first()).toBeVisible();
    // Back to all
    await page.getByRole("button", { name: "ALL", exact: true }).click();
    const total = await page.locator("table tbody tr").count();
    expect(total).toBeGreaterThanOrEqual(38);
  });

  test("Model detail page shows equation", async ({ page }) => {
    await page.goto("/models");
    await page.locator("table tbody tr").first().getByRole("link").first().click();
    await expect(page).toHaveURL(/\/models\/\d+/);
    // The detail page should render an equation block.
    await expect(page.locator("body")).toContainText(/=/);
  });

  test("Operations page lists rows", async ({ page }) => {
    await page.goto("/operations");
    await expect(page.getByRole("heading", { name: "Operations" })).toBeVisible();
    const count = await page.locator("table tbody tr").count();
    expect(count).toBeGreaterThanOrEqual(3);
  });

  test("Activities page lists rows + detail", async ({ page }) => {
    await page.goto("/activities");
    await expect(page.getByRole("heading", { name: "Activities" })).toBeVisible();
    await expect(page.locator("table tbody tr").first()).toBeVisible();
    await page.locator("table tbody tr").first().getByRole("link").first().click();
    await expect(page).toHaveURL(/\/activities\/\d+/);
  });

  test("Parameters page renders + search filter works", async ({ page }) => {
    await page.goto("/parameters");
    await expect(page.getByRole("heading", { name: "Parameters" })).toBeVisible();
    const before = await page.locator("table tbody tr").count();
    expect(before).toBeGreaterThan(0);
    await page.locator("input[type='text']").fill("vapor");
    // Filtering should narrow but not zero out.
    const after = await page.locator("table tbody tr").count();
    expect(after).toBeGreaterThan(0);
    expect(after).toBeLessThanOrEqual(before);
  });

  test("Generic Scenarios page renders", async ({ page }) => {
    await page.goto("/scenarios");
    await expect(page.getByRole("heading", { name: "Generic Scenarios" })).toBeVisible();
    await expect(page.locator("table")).toBeVisible();
  });
});
