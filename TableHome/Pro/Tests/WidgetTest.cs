using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableHome.Base;
using TableHome.Pro.Pages;

namespace TableHome.Pro.Tests
{
    [TestClass]
    public class WidgetTest : BaseTest
    {
        [TestMethod]
        public void TCID1()
        {
            var homePage = new HomePage(driver);
            var widgetPage = homePage.GoToWidgetPage();
            widgetPage.UploadImageFile();
            Assert.IsTrue(widgetPage.SuccessMessageDisplayed);
        }
    }
}
