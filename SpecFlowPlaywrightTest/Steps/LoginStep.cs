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
    public void ThenIAuthorize()
    {
        Console.WriteLine("authorize");
    }

    [Given(@"I click login link")]
    public async Task GivenIClickLoginLink()
    {
        await _loginPage.ClickLogin();
    }

    [Given(@"I fill login details")]
    public async Task GivenIFillLoginDetails(Table table)
    {
        dynamic loginData = table.CreateDynamicInstance();
        await _loginPage.Login((string) loginData.USERNAME, (string) loginData.PASSWORD);
    }

    [Given(@"I navigate")]
    public void GivenINavigate()
    {
        _page.GotoAsync("https://gallllery.com");
    }
}