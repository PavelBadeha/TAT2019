using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"Y:\Загрузки\chromedriver_win32");
            driver.Url = "https://mail.ru/";
            MailLoginPage loginPage = new MailLoginPage(driver);
            loginPage.LoginAs("sexgurupavel", "badzekha54");
            string str = loginPage.BadgetText();
           // driver.Quit();
            Console.Clear();
            Console.WriteLine("Ne pro4itano " + str);
            loginPage.ReadMessage();
            str = loginPage.BadgetText();
            Console.WriteLine("Ne pro4itano " + str);
        }
    }
}
