using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Dev_5
{
    class GmailLoginPage:PageObject
    {
        private By _usernameInputLocator = By.XPath("//input[@type='email']");
        private By _passwordInputLocator = By.XPath("//input[@type='password']");
        private IWebElement _usernameInput;
        private IWebElement _passwordInput;

        private string _loginTitle = "Gmail";

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public GmailLoginPage(IWebDriver driver) : base(driver) { }

        protected override void PageValidationCheck()
        {
            if (!_wait.Until(ExpectedConditions.TitleContains(_loginTitle)))
            {
                throw new NoValidPageException("This no inbox page");
            }
            _usernameInput = driver.GetIWebElementBy(_usernameInputLocator);
            _passwordInput = driver.GetIWebElementBy(_passwordInputLocator);
        }
        public IWebElement TypeUserName(string username)
        {
            _usernameInput.SendKeys(username);
            return _usernameInput;
        }
        public IWebElement TypePassword(string password)
        {
            _passwordInput.SendKeys(password);
            return _passwordInput;
        }
        public GmailInboxPage LoginAs(string username,string password)
        {
            TypeUserName(username + Keys.Enter);
            TypePassword(password + Keys.Enter);

            return new GmailInboxPage(driver);
        }
    }
}
