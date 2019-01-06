using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TableHome.Base
{
    
    public class BaseTest
    {
        public IWebDriver driver;        
        
        [TestInitialize]
        public void OneTimeInit() 
        {
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--headless");
            //driver = new ChromeDriver(chromeOptions);  
            driver = new BrowserFactory().GetBrowser(Browser.Chrome);                      
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.uitestpractice.com/");
        }

        [TestCleanup]
        public void OneTimeClean()
        {
            driver.Quit();
        }
    }
}
