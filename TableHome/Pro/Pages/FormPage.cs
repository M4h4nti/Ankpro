using OpenQA.Selenium;
using System.Collections.ObjectModel;
using TableHome.Base;
using TableHome.Utilities;
using static TableHome.Utilities.WebElementExtensions;

namespace TableHome.Pro.Pages
{
    public class FormPage : BaseClass
    {
        IWebElement Txt_FirstName => driver.FindElement(By.Id("firstname"));
        IWebElement Txt_LastName => driver.FindElement(By.Id("lastname"));
        ReadOnlyCollection<IWebElement> Rb_MaritialStatus => driver.FindElements(By.XPath("//*[@name='optradio']"));
        ReadOnlyCollection<IWebElement> Cb_Hobby => driver.FindElements(By.XPath("//*[@type='checkbox']"));
        IWebElement Ddl_Country => driver.FindElement(By.Id("sel1"));
        IWebElement Cal_DateOfBirth => driver.FindElement(By.Id("datepicker"));
        IWebElement Cal_Month => driver.FindElement(By.XPath("//*[@data-handler='selectMonth']"));
        IWebElement Cal_Year => driver.FindElement(By.XPath("//*[@data-handler='selectYear']"));
        IWebElement Cal_Date => driver.FindElement(By.ClassName("ui-datepicker-calendar"));
        IWebElement Txt_PhoneNumber => driver.FindElement(By.Id("phonenumber"));
        IWebElement Txt_UserName => driver.FindElement(By.Id("username"));
        IWebElement Txt_Email => driver.FindElement(By.Id("email"));
        IWebElement TXt_AboutYourself => driver.FindElement(By.Id("comment"));
        IWebElement Txt_Password => driver.FindElement(By.Id("pwd"));
        IWebElement Btn_Submit => driver.FindElement(By.XPath("//*[@type='submit']"));

        public FormPage(IWebDriver driver) : base(driver)
        {

        }

        public void RegisterToSite()
        {
            Txt_FirstName.EnterText("V");
            Txt_LastName.EnterText("K");
            SelectRandom(Rb_MaritialStatus).Click();
            SelectRandom(Cb_Hobby).Click();
            WebElementExtensions.SelectDropDownByText(Ddl_Country, "India");
            Cal_DateOfBirth.Click();
            WebElementExtensions.SelectDropDownByText(Cal_Month, "Feb");
            WebElementExtensions.SelectDropDownByText(Cal_Year, "1986");
            GetDate(Cal_Date, "14").Click();
            Txt_PhoneNumber.EnterText("098765434");
            Txt_UserName.EnterText("dfghj");
            Txt_Email.EnterText("dfgh@fgh.com");
            TXt_AboutYourself.EnterText("dfrtgvbjkj ytfyuh gtfyuhj ygu");
            Txt_Password.EnterText("dfgh123$");
            Btn_Submit.Click();
        }
    }
}
