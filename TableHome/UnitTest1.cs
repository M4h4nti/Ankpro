using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace TableHome
{
    [TestClass]
    public class UnitTest1 
    {
        IWebDriver Driver;
        private int ZValue = 100;
        private int ZInc = 10;
        
        [TestMethod]
        public void TestMethod1()
        {
            Driver = new ChromeDriver
            {
                Url = "https://www.google.com/"
            };

            Driver.Manage().Window.Maximize();
            Thread.Sleep(6000);

            for (int i = 0; i < 4; i++)
            {
                ZOut();
            }
            //ZOut();

            Thread.Sleep(6000);

            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript(string.Format("document.body.style.zoom='{0}%'", level));

            Console.WriteLine("resize end");
            Driver.Quit();
        }
        
        public void ZIn()
        {
            ZValue += ZInc;
            Zoom(ZValue);
        }
        public void ZOut()
        {
            ZValue -= ZInc;
            Zoom(ZValue);
        }
        private void Zoom(int level)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript(string.Format("document.body.style.zoom='{0}%'", level));
            Console.WriteLine($"resized to {level}");
        }
    }
}

