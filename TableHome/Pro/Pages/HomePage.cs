using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableHome.Base;

namespace TableHome.Pro.Pages
{
    class HomePage : BaseClass
    {
        IWebElement Link_Form => driver.FindElement(By.LinkText("Form"));
        IWebElement Link_Widget => driver.FindElement(By.LinkText("Widgets"));
        IWebElement Link_Action => driver.FindElement(By.LinkText("Actions"));

        
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public FormPage GoToFormPage()
        {
            Link_Form.Click();
            return new FormPage(driver);
        }

        public WidgetPage GoToWidgetPage()
        {
            Link_Widget.Click();
            return new WidgetPage(driver);
        }

        public ActionsPage GoToActionsPage()
        {
            Link_Action.Click();
            return new ActionsPage(driver);
        }
    }
}
