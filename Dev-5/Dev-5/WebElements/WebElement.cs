using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Dev_5
{
    abstract class WebElement
    {
        protected IWebElement _element;
        protected WebDriverWait _wait;
        protected IWebDriver driver;
        protected By locator;
        public WebElement(IWebDriver driver)
        {
            this.driver = driver;
            _wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

    }
}
