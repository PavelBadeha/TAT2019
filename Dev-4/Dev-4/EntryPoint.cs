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
            try
            {
                IWebDriver driver = new ChromeDriver();

                MailRu mailRu = new MailRu(driver);

                mailRu.NavigetToLoginPage();
                mailRu.LoginAs("kodzimaisgenius", "DeathStranding");
                Console.WriteLine(mailRu.GetUnreadMessagesCount());
                mailRu.ReadUnreadMessage();
                Console.WriteLine(mailRu.GetUnreadMessagesCount());
                mailRu.NavigateToMainPage();
                driver.Quit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
