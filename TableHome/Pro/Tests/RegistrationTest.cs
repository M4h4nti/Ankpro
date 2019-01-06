using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableHome.Base;
using TableHome.Pro.Pages;

namespace TableHome.Pro.Tests
{
    [TestClass]
    public class RegistrationTest : BaseTest
    {
        [TestMethod]
        public void TCID1()
        {
            var homePage = new HomePage(driver);
            var formPage = homePage.GoToFormPage();
            formPage.RegisterToSite();
        }
    }
}
