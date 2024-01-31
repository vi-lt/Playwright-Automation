using BigEcommerceApp.Tests.Models;
using Microsoft.Playwright;
using PlaywrightTests.Utilities;

namespace PlaywrightTests.Setup
{
    public class Helpers
    {
        public static IPlaywright? IPlaywright { get; set; }
        public static IBrowser? IBrowser { get; set; } = null!;
        public static IPage? IPage { get; set; } = null!;
        public static IBrowserContext? BrowserContext { get; set; } = null!;
        public static PageObjectModel? PageObjectModel;
        public static Common? Common;
        public static bool FirstTimeSetUp { get; set; } = true;
    }
}
