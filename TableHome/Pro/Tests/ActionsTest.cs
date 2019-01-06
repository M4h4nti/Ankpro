using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableHome.Base;
using TableHome.Pro.Pages;
using static TableHome.Utilities.WaitHelper;

namespace TableHome.Pro.Tests
{
    [TestClass]
    public class ActionsTest : BaseTest
    {
        ActionsPage actionsPage;
        [TestInitialize]
        public void Setup()
        {
            var homePage = new HomePage(driver);
            actionsPage = homePage.GoToActionsPage();
        }
        [TestMethod]
        public void TCID1()
        {            
            actionsPage.Click_ClickMeButton();
            Assert.AreEqual("Clicked !!", actionsPage.GetTextFromAlert());
            Console.WriteLine(actionsPage.GetTextFromAlert());
            actionsPage.AcceptAlert();
        }
        [TestMethod]
        public void TCID2()
        {            
            actionsPage.Click_DoubleClickButton();
            Assert.AreEqual("Double Clicked !!", actionsPage.GetTextFromAlert());
            Console.WriteLine(actionsPage.GetTextFromAlert());
            actionsPage.AcceptAlert();
        }
        [TestMethod]
        public void TCID3()
        {            
            actionsPage.HoverOntoElement();
            Assert.IsTrue(actionsPage.HoverElementColorChanged);
            //Console.WriteLine(actionsPage.GetTextFromAlert());
            //actionsPage.AcceptAlert();
        }
        [TestMethod]
        public void TCID4()
        {
            Console.WriteLine(actionsPage.DroppableElementText);
            actionsPage.DragNDropByMethod();            
            Assert.AreEqual("Dropped!", actionsPage.DroppableElementText);
            Console.WriteLine(actionsPage.DroppableElementText);
        }
    }
}
