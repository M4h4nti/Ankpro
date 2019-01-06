using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TableHome.Utilities
{
    public static class WebElementExtensions
    {
        public static void EnterText(this IWebElement element,string textToEnter)
        {
            element.Clear();
            element.SendKeys(textToEnter);
        }

        public static void SelectDropDownByText(this IWebElement element, string text)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(text);
        }

        public static IWebElement SelectRandom(ReadOnlyCollection<IWebElement> elements)
        {
            Random random = new Random();
            return elements[random.Next(elements.Count)];
        }

        public static IWebElement GetDate(IWebElement table, string date)
        {
            //var rows = table.FindElements(By.TagName("tr"));
            //var rowHeader = table.FindElements(By.TagName("th"));

            //int rowIndex = 0;

            //foreach (var row in rows)
            //{
            //    int columnIndex = 0;
            //    var dateValues = table.FindElements(By.TagName("td"));
            //    foreach (var dateValue in dateValues)
            //    {
            //        table.FindElement(By.XPath)
            //    }
            //}

            return table.FindElement(By.XPath($"//td/a[contains(text(),'{date}')]"));
        }

    }
}
