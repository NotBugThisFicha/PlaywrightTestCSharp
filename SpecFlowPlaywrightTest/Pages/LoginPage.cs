using Microsoft.Playwright;

namespace SpecFlowPlaywrightTest.Pages;
public class LoginPage
{
    private readonly IPage _page;

    private readonly ILocator _lnkLogin;
    private readonly ILocator _txtUserName;
    private readonly ILocator _txtPassword;
    private readonly ILocator _btnLogin;

    public LoginPage(IPage page)
    {
        _page = page;
        _lnkLogin = page.Locator("#navbar > div.sc-gsFSXq.sc-iQbOkh.gZPyPU.bqIRQR > div:nth-child(2) > div:nth-child(4) > div > div");
        _txtUserName = page.Locator("#mailInput");
        _txtPassword = page.Locator("#password-input");
        _btnLogin = page.Locator("#login-button");
    }

    public async Task ClickLogin() => await _lnkLogin.ClickAsync();

    public async Task Login(string userName, string password)
    {
        await _txtUserName.FillAsync(userName);
        await _txtPassword.FillAsync(password);
    }

    public async Task ClickAuthorize() => await _btnLogin.ClickAsync();
}