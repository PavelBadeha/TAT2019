using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Dev_4
{
    class MailLoginPage
    {
        private IWebDriver driver;
        private string title = "Mail.ru: почта, поиск в интернете, новости, игры";
        private By usernameLocator = By.Id("mailbox:login");
        private By passwordLocator = By.Id("mailbox:password");
        private By badgetLocator = By.ClassName("badge__text");
        private By messageLocator = By.ClassName("b-checkbox__checkmark");
        private IWebElement usernameInput;
        private IWebElement passwordInput;
        private IWebElement badget;
        private IWebElement message;
        public MailLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            if (!title.Equals(driver.Title))
            {
               throw new Exception("This no login page");
            }
        }
        public void ReadMessage()
        {
            message = driver.FindElement(messageLocator);
            message.Click();
        }
        public void TypeUserName(string username)
        {
            usernameInput = driver.FindElement(usernameLocator);
            usernameInput.SendKeys(username);
            usernameInput.Submit();
        }
        public void TypePassword(string password)
        {
            passwordInput = driver.FindElement(passwordLocator);
            passwordInput.SendKeys(password);
            passwordInput.Submit();
        }
        public void LoginAs(string username,string password)
        {
            TypeUserName(username);
            TypePassword(password);
        }
        public string BadgetText()
        {
            badget = driver.FindElement(badgetLocator);
            return badget.Text;
        }
    }
}
