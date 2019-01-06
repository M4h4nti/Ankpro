using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace TableHome.Base
{
    enum Browser
    {
        Firefox,
        Chrome,
        Edge,
        Safari
    }
    class BrowserFactory
    {
        //IWebDriver Driver = new BaseClass(IWebDriver driver);

        public IWebDriver GetBrowser(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    return GetChromeBrowser();
                case Browser.Firefox:
                    return GetFifoxBrowser();
                case Browser.Edge:
                    return GetEdgeBrowser();
                case Browser.Safari:
                    return GetSafariBrowser();
                default:
                    throw new ArgumentException("No browser of this type..");
                    
            }
        }

        private IWebDriver GetFifoxBrowser()
        {
            throw new NotImplementedException();
        }

        private IWebDriver GetSafariBrowser()
        {
            throw new NotImplementedException();
        }

        private IWebDriver GetEdgeBrowser()
        {
            return new FirefoxDriver();
        }        

        private IWebDriver GetChromeBrowser()
        {
            return new ChromeDriver();
        }
    }
}
