using Microsoft.Playwright;
using NUnit.Allure.Attributes;

namespace BigEcommerceApp.Tests.Models;

public class PageObjectModel(IPage Page)
{
    private readonly IPage _page = Page;
    private ILocator menu_API => _page.Locator("//a[text()='API']");
    private ILocator menu_left(string nameMenu) => _page.Locator("//ul[@class='menu__list']//a[text()='"+ nameMenu + "']");

    //Action
    [AllureStep]
    public async Task Click_APIMenu()
    {
        await menu_API.ClickAsync();
    }

    [AllureStep]
    public async Task Click_MenuLeft(string nameMenu)
    {
        await menu_left(nameMenu).ClickAsync();
    }

}