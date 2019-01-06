using OpenQA.Selenium;

namespace TableHome.Base
{
    public class BaseClass
    {
        public IWebDriver driver;

        public BaseClass(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
