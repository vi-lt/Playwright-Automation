using Microsoft.Playwright;

namespace PlaywrightTests.Utilities
{

    public class Common(IPage Page)
    {
        private readonly IPage _page = Page;

        //Navigate to IPage
        public async Task Navigate(string Url)
        {
            await _page.GotoAsync(Url);
        }

        //Close Browser
        public async Task CloseBrowser()
        {
            await _page.CloseAsync();
        }

        //Action with keyboard
        public async Task PresEnterButton(ILocator locator)
        {
            await locator.PressAsync("Enter");
        }

        //Wait to load
        public async Task WaitToLoadTimeOut(float timeout)
        {
            await _page.WaitForTimeoutAsync(timeout);
        }
    }
}
