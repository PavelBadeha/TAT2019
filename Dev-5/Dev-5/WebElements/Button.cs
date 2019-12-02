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
    class Button:WebElement
    {      
        public Button(IWebDriver driver,By locator):base(driver)
        {
            this.locator = locator;
           _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
        public void Click()
        {
           _element = _wait.Until(ExpectedConditions.ElementIsVisible(locator));
           _element.Click();
        }
    }
}
