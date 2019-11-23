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
        private string loginTitle = "Mail.ru: почта, поиск в интернете, новости, игры";
        private By usernameLocator = By.Id("mailbox:login");
        private By passwordLocator = By.Id("mailbox:password");
        private IWebElement usernameInput;
        private IWebElement passwordInput;

        public MailLoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (!loginTitle.Equals(driver.Title))
            {
               throw new Exception("This no login page");
            }
        }
        public MailLoginPage TypeUserName(string username)
        {
            usernameInput = driver.FindElement(usernameLocator);
            usernameInput.SendKeys(username);
            usernameInput.Submit();
            return this;
        }
        public MailLoginPage TypePassword(string password)
        {
            passwordInput = driver.FindElement(passwordLocator);
            passwordInput.SendKeys(password);
            passwordInput.Submit();
            return this;
        }
        public MailInboxPage LoginAs(string username,string password)
        {
            TypeUserName(username);
            TypePassword(password);
            return new MailInboxPage(driver);
        }
       
    }
}
