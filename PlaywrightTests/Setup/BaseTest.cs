using BigEcommerceApp.Tests.Models;
using Microsoft.Extensions.Configuration;
using NUnit.Allure.Core;
using PlaywrightTests.Utilities;

namespace PlaywrightTests.Setup
{
    [AllureNUnit]
    public class BaseTest : Helpers
    {
        public readonly string BaseUrl;
        public static string PageUrl;

        public BaseTest()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsetttings.json")
                .Build();

            BaseUrl = config["BaseUrl"].ToString();
            PageUrl = $"{config["BaseUrl"]}";
        }

        [OneTimeSetUp]
        public static async Task SetUpOnce()
        {
            if (FirstTimeSetUp == true)
            {
                await FilesAndDirectory.DeleteAllFilesInFolder(@"\allure-results");
                FirstTimeSetUp = false;
            }
        }

        [SetUp]
        public static async Task SetUp()
        {
            await TestSetup.Setup();

            PageObjectModel = new PageObjectModel(IPage);
            Common = new Common(IPage);

            await Common.Navigate(PageUrl);
        }

        [TearDown]
        public static async Task TearDown()
        {
            await Common.CloseBrowser();

        }
    }
}
