using Microsoft.Playwright;
using NUnit.Allure.Attributes;
using PlaywrightTests.Setup;

namespace PlaywrightTests;
[AllureSuite("Test Suite")]
[AllureFeature("Feature")]
public partial class VerifyPage : BaseTest
{
    [Test]
    [AllureName("Verify Default UI")]
    [AllureTag("UI")]
    public async Task VerifyDefaultUI()
    {
        await PageObjectModel.Click_APIMenu();
        await Common.WaitToLoadTimeOut(5000);
        await PageObjectModel.Click_MenuLeft("Browser");
        await Common.WaitToLoadTimeOut(5000);
    }

}