using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableHome.Base;

namespace TableHome.Pro.Pages
{
    class ActionsPage : BaseClass
    {
        IAlert alert;
        Actions action;
        string styleBeforHover, styleAfterHover;
        public ActionsPage(IWebDriver driver) : base(driver)
        {

        }

        IWebElement Btn_ClickMe => driver.FindElement(By.Name("click"));
        IWebElement Btn_DoubleClick => driver.FindElement(By.Name("dblClick"));
        IWebElement Lbl_HoverElement => driver.FindElement(By.Id("div2"));
        IWebElement DraggableElement => driver.FindElement(By.Id("draggable"));
        IWebElement DroppableElement => driver.FindElement(By.Id("droppable"));
        IWebElement SelectableElement => driver.FindElement(By.Id("selectable"));


        public void Click_ClickMeButton()
        {
            Btn_ClickMe.Click();
        }

        public void Click_DoubleClickButton()
        {
            CreateActionInstance();
            //Btn_DoubleClick.Click();
            action.DoubleClick(Btn_DoubleClick).Perform();
        }

        public void HoverOntoElement()
        {
            styleBeforHover = Lbl_HoverElement.GetAttribute("style");
            HoverOnElement(Lbl_HoverElement);
            styleAfterHover = Lbl_HoverElement.GetAttribute("style");
        }

        public bool HoverElementColorChanged => (styleBeforHover != styleAfterHover) ? true : false;
        //if (styleAfterHover != styleBeforHover)
        //    return true;
        //else return false;
        //}

        public string DroppableElementText => DroppableElement.Text;

        public void DragNDropByMethod()
        {
            CreateActionInstance();
            action.DragAndDrop(DraggableElement, DroppableElement).Perform();
            //return DroppableElement.Text;
        }

        public void DragNDropByActions()
        {

        }

        public void HoverOnElement(IWebElement element)
        {
            CreateActionInstance();
            action.MoveToElement(element).Perform();
        }

        private void CreateActionInstance()
        {
            action = new Actions(driver);
        }

        private void HandlePopup()
        {
            alert = driver.SwitchTo().Alert();
            //alert.
        }

        public void AcceptAlert()
        {
            HandlePopup();
            alert.Accept();
        }

        public void DismissAlert()
        {
            HandlePopup();
            alert.Dismiss();
        }

        public void EnterTextToAlert(string text)
        {
            HandlePopup();
            alert.SendKeys(text);
        }

        public string GetTextFromAlert()
        {
            HandlePopup();
            return alert.Text;
        }

    }
}
