using System;
using OpenQA.Selenium;

namespace Dev_4
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

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            PageValidationCheck();
        }

        /// <summary>
        /// Method that checks for page validation
        /// </summary>
        protected abstract void PageValidationCheck();
    }
}
