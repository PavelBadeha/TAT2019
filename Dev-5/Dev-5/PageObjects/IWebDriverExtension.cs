using System;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Dev_5
{
    /// <summary>
    /// Class of IWebDriver extension
    /// </summary>
    public static class IWebDriverExtension
    {
        /// <summary>
        /// Extension method that returns IWebElement by locator
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="locator"></param>
        /// <returns></returns>
        public static IWebElement GetIWebElementBy(this IWebDriver driver,By locator)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
