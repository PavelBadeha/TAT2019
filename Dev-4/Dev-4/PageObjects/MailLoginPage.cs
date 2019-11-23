using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class of login page
    /// </summary>
    class MailLoginPage:PageObject
    {
        private By usernameLocator = By.Name("Login");
        private By passwordLocator = By.Name("Password");
        private IWebElement usernameInput;
        private IWebElement passwordInput;

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
            usernameInput = driver.FindElement(usernameLocator);
            usernameInput.SendKeys(username);
            return usernameInput;
        }

        /// <summary>
        /// Method that types password to password field
        /// </summary>
        /// <param name="password">Password</param>
        /// <returns>Web element of password field</returns>
        public IWebElement TypePassword(string password)
        {
            passwordInput = driver.FindElement(passwordLocator);
            passwordInput.SendKeys(password);
            return passwordInput;
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
