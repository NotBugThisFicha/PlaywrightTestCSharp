using Microsoft.Playwright;
using SpecFlowPlaywrightTest.Drivers;
using SpecFlowPlaywrightTest.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPlaywrightTest.Steps;

[Binding]
public sealed class LoginStep
{

    private readonly Driver _driver;
    private readonly IPage _page;
    private readonly LoginPage _loginPage;

    public LoginStep(Driver driver)
    {
        _driver = driver;
        _page = _driver.Page;
        _loginPage = new LoginPage(_page);
    }


    [Then(@"I authorize")]
    public async void ThenIAuthorize()
    {
        await _loginPage.ClickAuthorize();
    }

    [Given(@"I click login link")]
    public async void GivenIClickLoginLink()
    {
        await _loginPage.ClickLogin();
    }

    [Given(@"I fill login details")]
    public async void GivenIFillLoginDetails(Table table)
    {
        dynamic loginData = table.CreateDynamicInstance();
        await _loginPage.Login((string) loginData.USERNAME, (string) loginData.PASSWORD);
    }

    [Given(@"I navigate")]
    public async void GivenINavigate()
    {
        await _page.GotoAsync("https://gallllery.com/");
    }
}