using Microsoft.Playwright;

namespace PlaywrightTests.Setup
{
    public class TestSetup : Helpers
    {
        public static async Task Setup()
        {
            IPlaywright = await Playwright.CreateAsync();
            IBrowser = await IPlaywright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                Args = new List<string> { "--start-maximized" }
            });
            BrowserContext = await IBrowser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = ViewportSize.NoViewport
            });
            IPage = await BrowserContext.NewPageAsync();
        }
    }
}
