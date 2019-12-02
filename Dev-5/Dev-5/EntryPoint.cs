using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_5
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method
        /// </summary>
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mail.ru/";
            MailLoginPage loginPage = new MailLoginPage(driver);
            MailInboxPage inboxPage = loginPage.LoginAs("kodzimaisgenius", "DeathStranding");
            inboxPage.ReadUnreadMessage();
            inboxPage.SendMessage("hideoisgenius.v.2@gmail.com", DateTime.Now.ToString());
            
            IWebDriver driver1 = new ChromeDriver();
            driver1.Manage().Window.Maximize();
            driver1.Url = "https://mail.google.com/";
            GmailLoginPage gmailLoginPage = new GmailLoginPage(driver1);
            GmailInboxPage gmailInboxPage = gmailLoginPage.LoginAs("hideoisgenius.v.2@gmail.com", "DeathStranding");
            GmailLetterPage gmailLetterPage = gmailInboxPage.ReadMessageFrom("kodzimaisgenius@mail.ru");
            gmailLetterPage.Reply("Ne ponyal");
            Thread.Sleep(1000);
            driver1.Quit();

            driver.Navigate().Refresh();
            inboxPage.ReadUnreadMessage();
        }
    }
}
