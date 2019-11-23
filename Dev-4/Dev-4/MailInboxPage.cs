using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace Dev_4
{
    class MailInboxPage
    {
        private IWebDriver driver;
        private By badgetLocator = By.ClassName("badge__text");
        private By unreadMessageLocator = By.ClassName("llc__item_flag");
        private IWebElement badget;
        private IWebElement unreadMessage;
        public string inboxTitle = "(3) Входящие - Почта Mail.ru";

        public MailInboxPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (!inboxTitle.Equals(driver.Title))
            {
               // throw new Exception("This no inbox page");               
            }
        }
        public string BadgetText()
        {
            badget = driver.FindElement(badgetLocator);
            return badget.Text;
        }
        public void ReadUnreadMessage()
        {
            unreadMessage = driver.FindElement(unreadMessageLocator);
            unreadMessage.Click();
            //unreadMessage.FindElement(By.ClassName("ll-rs")).Click();
        }
    }
}
