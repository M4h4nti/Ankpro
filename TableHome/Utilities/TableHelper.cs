using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableHome.Utilities
{
    public class TableHelper
    {
        static IWebDriver Driver;
        public static string GetTableXpath(string locator, int row, int col)
        {
            return $"{locator}[{row}]/td[{col}]";
            //where your locator should be this : /html/body/div[2]/div/div[2]/section/div/table/tbody/tr
        }


        // Get a single cell value
        public static string GetColumnValue(string @locator, int @row, int @col)
        {
            string TableXpath = GetTableXpath(locator, row, col);
            string value = string.Empty;

            if (IsElementPresent(By.XPath(TableXpath)))
            {
                value = Driver.FindElement(By.XPath(TableXpath)).Text;
                return value;
            }
            else return string.Empty;
        }

        //If you want to get all values of the table, Get all the table values, and put in a list<string> and iterate through each item using foreach



        public static bool IsElementPresent(By Locator)
        {
            try
            {
                List<IWebElement> elements = Driver.FindElements(Locator).ToList();
                return (elements.Count > 1) ? true : false;//If the element is present, this is true
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

