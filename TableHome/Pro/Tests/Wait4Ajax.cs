using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TableHome.Base;

namespace TableHome.Pro.Tests
{
    [TestClass]
    [TestCategory("Ajax")]
    [TestCategory("WebWait")]
    public class Wait4Ajax : BaseTest
    {
        [TestMethod]
        [Description("Wait till page and assert !!!")]
        [TestProperty("Author", "VJKumar")]
        public void TCID1()
        { 
            driver.FindElement(By.LinkText("AjaxCall")).Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Window.FullScreen();
            driver.FindElement(By.XPath("//*[contains(@href,'P1')]")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(x => x.FindElement(By.Id("Result")).Text.Contains("Ruby"));

            Assert.IsTrue(driver.PageSource.Contains("Selenese"));
        }
    }
}
