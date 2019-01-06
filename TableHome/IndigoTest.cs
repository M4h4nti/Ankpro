using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TableHome
{
    [TestClass]
    public class IndigoTest
    {
        IWebDriver Driver;
        [TestInitialize]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Url = "https://www.goindigo.in/";
        }
        [TestMethod]
        public void TestMethod1()
        {
            Driver.FindElement(By.XPath("//*[@href='#oneWay']")).Click();
            //System.Threading.Thread.Sleep(30000);
            Console.WriteLine(Driver.FindElement(By.XPath("//*[@id='globalModal']//*[@class= 'modal-body']")).Text);
            Driver.FindElement(By.XPath("//*[@id='globalModal']//button[text() = 'OK']")).Click();
            System.Threading.Thread.Sleep(10000);
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
