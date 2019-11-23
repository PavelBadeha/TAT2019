using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class for main mail page
    /// </summary>
    class MainMailPage : PageObject
    {
        private IWebElement _loginPageButton;
        private IWebElement _inboxPageButton;
        private By _loginPageButtonLocator = By.ClassName("social__link");
        private By _inboxPageButtonLocator = By.CssSelector("[href*='https://r.mail.ru/n109322792']");

        /// <summary>
        /// Page title
        /// </summary>
        public string MainPageTitle { get; } ="Mail.Ru";

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public MainMailPage(IWebDriver driver) : base(driver) { }

        protected override void PageValidationCheck()
        {
            if (!driver.Title.Equals(MainPageTitle))
            {
                throw new NoValidPageException();
            }
        }

        /// <summary>
        /// Method that navigates to inbox page
        /// </summary>
        /// <returns>Inbox page</returns>
        public MailInboxPage NavigateToMailInboxPage()
        {
            _inboxPageButton = driver.FindElement(_inboxPageButtonLocator);
            _inboxPageButton.Click();
            return new MailInboxPage(driver);
        }

        /// <summary>
        /// Method that navigates to login page
        /// </summary>
        /// <returns>Login page</returns>
        public MailLoginPage NavigateToLoginPage()
        {
            _loginPageButton = driver.FindElement(_loginPageButtonLocator);
            _loginPageButton.Click();
            return new MailLoginPage(driver);
        }
    }
}
