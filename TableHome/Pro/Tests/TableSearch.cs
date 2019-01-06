using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TableHome.Base;
using TableHome.Utilities;

namespace TableHome.Pro.Tests
{
    [TestClass]   
    [TestCategory("Table")]
    public class TableSearch : BaseTest
    {        
        [TestMethod]
        [Description("Search for the field in Table")]
        [TestProperty("Author","VJKumar")]
        [Priority(1)]
        //[DataRow("Prasad")]
        //[DataRow("Ravi")]
        public void TCID1()
        {
            //IWebElement searchBox = driver.FindElement(By.Id("Search_Data"));
            //searchBox.Clear();
            //searchBox.SendKeys(searchValue);
            //driver.FindElement(By.XPath("//input[@value='Find']")).Click();  
            driver.FindElement(By.LinkText("Home")).Click();
            IWebElement table = driver.FindElement(By.XPath("//*[@class='table']"));
            TableUtility.ReadTable(table);
            //string result = TableUtility.ReadCell("Last Name", 5, out int count);
            Console.WriteLine(TableUtility.ReadCell("Last Name", 5));
            //Console.WriteLine(rows + "   " + columns + "  " + last);
        }
    }
}
