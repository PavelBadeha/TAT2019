using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_4
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver(@"Y:\Загрузки\chromedriver_win32");
            driver.Url = "https://mail.ru/";

            MailLoginPage loginPage = new MailLoginPage(driver);
            MailInboxPage inboxPage = loginPage.LoginAs("sexgurupavel", "badzekha54");

            Console.Clear();
            Console.WriteLine(inboxPage.BadgetText());

            inboxPage.ReadUnreadMessage();
            Console.WriteLine(inboxPage.BadgetText());
            driver.Quit();
        }
    }
}
