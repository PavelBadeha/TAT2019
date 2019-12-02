using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Dev_5
{
    /// <summary>
    /// Absract class for all page objects
    /// </summary>
    abstract class PageObject
    {
        /// <summary>
        /// Driver that page will use
        /// </summary>
        protected IWebDriver driver;

        protected WebDriverWait _wait;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
            _wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30)); 
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PageValidationCheck();
        }

        /// <summary>
        /// Method that checks for page validation
        /// </summary>
        protected abstract void PageValidationCheck();
    }
}
