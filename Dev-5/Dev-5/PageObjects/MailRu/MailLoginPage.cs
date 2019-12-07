using OpenQA.Selenium;

namespace Dev_5
{
    /// <summary>
    /// Class of login page
    /// </summary>
    class MailLoginPage : PageObject
    {
        private By _usernameLocator = By.Id("mailbox:login");
        private By _passwordLocator = By.Id("mailbox:password");
        private IWebElement _usernameInput;
        private IWebElement _passwordInput;

        /// <summary>
        /// Page title
        /// </summary>
        public string LoginTitle { get; } = "Mail.ru: почта, поиск в интернете, новости, игры";

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public MailLoginPage(IWebDriver driver) : base(driver) { }

        protected override void PageValidationCheck()
        {
            if (!LoginTitle.Equals(driver.Title))
            {
               throw new NoValidPageException("This no login page");
            }
            _usernameInput = driver.GetIWebElementBy(_usernameLocator);
            _passwordInput = driver.GetIWebElementBy(_passwordLocator);
        }

        /// <summary>
        /// Method that types username to username field
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns>Web element of username field</returns>
        public IWebElement TypeUserName(string username)
        {
            _usernameInput.SendKeys(username);
            return _usernameInput;
        }

        /// <summary>
        /// Method that types password to password field
        /// </summary>
        /// <param name="password">Password</param>
        /// <returns>Web element of password field</returns>
        public IWebElement TypePassword(string password)
        {
            _passwordInput.SendKeys(password);
            return _passwordInput;
        }

        /// <summary>
        /// Method that logins
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Inbox page</returns>
        public MailInboxPage LoginAs(string username, string password)
        {
            TypeUserName(username).Submit();
            TypePassword(password).Submit();
            return new MailInboxPage(driver);
        }
    }
}
