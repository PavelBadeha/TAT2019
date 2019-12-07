using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class of MailRu
    /// </summary>
    class MailRu
    {
        private MainMailPage _mainPage;
        private MailLoginPage _loginPage;
        private MailInboxPage _inboxPage;
        private IWebDriver _driver;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver">Driver that will be used</param>
        public MailRu(IWebDriver driver)
        {
            _driver = driver;
            _driver.Url= "https://m.mail.ru/";
            _mainPage = new MainMailPage(_driver);
        }

        /// <summary>
        /// Method that navigates to the login page
        /// </summary>
        /// <returns></returns>
        public MailLoginPage NavigetToLoginPage()
        {
            _loginPage = _mainPage.NavigateToLoginPage();
            return _loginPage;
        }

        /// <summary>
        /// Method that logins 
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Inbox page</returns>
        public MailInboxPage LoginAs(string username,string password)
        {
            _inboxPage = _loginPage.LoginAs(username, password);
            return _inboxPage;
        }

        /// <summary>
        /// Method that navigates to the main page
        /// </summary>
        /// <returns></returns>
        public MainMailPage NavigateToMainPage()
        {
            _driver.Url = "https://m.mail.ru/";
            return _mainPage = new MainMailPage(_driver);
        }

        /// <summary>
        /// Method that returns count of unread messages
        /// </summary>
        public string GetUnreadMessagesCount()
        {
            return _inboxPage.GetUnreadMessagesCount();
        }

        /// <summary>
        /// Method that read unread messages
        /// </summary>
        /// <returns>Inbox page</returns>
        public MailInboxPage ReadUnreadMessage()
        {
            _inboxPage.ReadUnreadMessage();
            return _inboxPage;
        }
    }
}
