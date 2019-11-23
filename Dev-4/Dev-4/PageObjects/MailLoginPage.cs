using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class of login page
    /// </summary>
    class MailLoginPage:PageObject
    {
        private By _usernameLocator = By.Name("Login");
        private By _passwordLocator = By.Name("Password");
        private IWebElement _usernameInput;
        private IWebElement _passwordInput;

        /// <summary>
        /// Page title
        /// </summary>
        public string LoginTitle { get; } = "Вход — Почта Mail.Ru";

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
        }

        /// <summary>
        /// Method that types username to username field
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns>Web element of username field</returns>
        public IWebElement TypeUserName(string username)
        {
            _usernameInput = driver.FindElement(_usernameLocator);
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
            _passwordInput = driver.FindElement(_passwordLocator);
            _passwordInput.SendKeys(password);
            return _passwordInput;
        }

        /// <summary>
        /// Method that logins
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>Inbox page</returns>
        public MailInboxPage LoginAs(string username,string password)
        {
            TypeUserName(username);
            TypePassword(password).Submit();
            return new MailInboxPage(driver);
        }
       
    }
}
