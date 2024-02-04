using System;
using Microsoft.Playwright;

namespace SpecFlowPlaywrightTest.Drivers
{
    public class Driver: IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;

        public Driver()=> _page = InitializePage();
        public IPage Page => _page.Result;
        
        public void Dispose()=> _browser?.CloseAsync();

        private async Task<IPage> InitializePage()
        {
             IPlaywright playwright = await Playwright.CreateAsync();
            
            _browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            return await _browser.NewPageAsync();
        }
        
    }
}