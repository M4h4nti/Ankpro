using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableHome.Base;
using TableHome.Utilities;

namespace TableHome.Pro.Pages
{
    class WidgetPage : BaseClass
    {
        string filePath = @"C:\Users\user\Downloads\images.png";
        public WidgetPage(IWebDriver driver) : base(driver)
        {

        }

        IWebElement Btn_ChooseFile => driver.FindElement(By.Id("image_file"));
        IWebElement Btn_Upload => driver.FindElement(By.XPath("//*[contains(@value,'Upload')]"));

        IWebElement Lbl_SuccessMessage => driver.FindElement(By.XPath("//*[contains(@class,'ContactUs')]"));

        

        public void UploadImageFile()
        {
            Btn_ChooseFile.SendKeys(filePath);
            Btn_Upload.Click();
        }

        public bool SuccessMessageDisplayed => WaitHelper.WaitTillElementIsVisible(driver,By.XPath("//*[contains(@class,'ContactUs')]"));
    }
}
