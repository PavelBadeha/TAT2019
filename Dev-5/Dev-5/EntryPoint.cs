using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_5
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://mail.ru/";
            MailLoginPage loginPage = new MailLoginPage(driver);
            MailInboxPage inboxPage =  loginPage.LoginAs("kodzimaisgenius", "DeathStranding");
            //  inboxPage.ReadUnreadMessage();
            // inboxPage.SendMessage("pbadzekha@mail.ru",DateTime.Now.ToString());
            IWebDriver driver1 = new ChromeDriver();
            driver1.Url = "https://mail.google.com/";
        }
    }
}
