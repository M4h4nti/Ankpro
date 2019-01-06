using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TableHome.Base;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TableHome.Utilities
{
    public static class WaitHelper 
    {
        //static readonly IWebDriver driver;
        static WebDriverWait wait;

        public static bool WaitTillElementIsVisible(IWebDriver driver,By by)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            //wait.Until(ExpectedConditions.ElementIsVisible(by));
        }        
    }
}
