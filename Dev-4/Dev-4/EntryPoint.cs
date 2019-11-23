using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_4
{
    /// <summary>
    /// Class of entry point
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// Main method of program
        /// </summary>
        static void Main()
        {
            IWebDriver driver = new ChromeDriver(@"Y:\Загрузки\chromedriver_win32");
            driver.Url = "https://m.mail.ru/";

            MainMailPage mailPage = new MainMailPage(driver);
            MailLoginPage loginPage =  mailPage.NavigateToLoginPage();
            MailInboxPage inboxPage = loginPage.LoginAs("kodzimaisgenius", "DeathStranding");

            Console.Clear();
            Console.WriteLine("unread messages counter = " + inboxPage.GetUnreadMessagesCount());
            inboxPage.ReadUnreadMessage();
            Console.WriteLine("unread messages counter = " + inboxPage.GetUnreadMessagesCount());
            inboxPage.NavigateToMainMailPage();
            driver.Quit();
        }
    }
}
