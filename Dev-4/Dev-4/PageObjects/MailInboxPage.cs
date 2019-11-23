using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class for inbox page
    /// </summary>
    class MailInboxPage:PageObject
    {
        private By _unreadMessagesCounterLocator = By.ClassName("msglist-title__counter");
        private By _messageLocator = By.CssSelector(".js-messageline.messageline.messageline_unread");
        private By _mainMailPageButtonLocator = By.CssSelector("[href*='http://m.mail.ru']");
        private IWebElement _unreadMessagesCounter;
        private IWebElement _unreadMessage;
        private IWebElement _mainMailPageButton;

        /// <summary>
        /// Array of strings that page title must be have
        /// </summary>
        public string[] InboxTitle { get; } = new string[] { "Входящие", "Почта Mail.ru" };

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public MailInboxPage(IWebDriver driver) : base(driver) { }

        protected override void PageValidationCheck()
        {
            if (!driver.Title.Contains(InboxTitle[0]) && !driver.Title.Contains(InboxTitle[1]))
            {
                throw new NoValidPageException("This no inbox page");               
            }
        }

        /// <summary>
        /// Method that returns count of unread messages
        /// </summary>
        /// <returns></returns>
        public string GetUnreadMessagesCount()
        {
           try
            {
                _unreadMessagesCounter = driver.FindElement(_unreadMessagesCounterLocator);
                return _unreadMessagesCounter.Text;
            }
            catch(NoSuchElementException)
            {
                return 0.ToString();
            }
        }

        /// <summary>
        /// Method that reads unread message
        /// </summary>
        public void ReadUnreadMessage()
        {
            try
            {
                _unreadMessage = driver.FindElement(_messageLocator);
                _unreadMessage.Click();
                driver.Navigate().Back();
            }
            catch(NoSuchElementException)
            {

            }
        }

        /// <summary>
        /// Method that navigates to main page
        /// </summary>
        /// <returns>Maine page</returns>
        public MainMailPage NavigateToMainMailPage()
        {
            _mainMailPageButton = driver.FindElement(_mainMailPageButtonLocator);
            _mainMailPageButton.Click();
            return new MainMailPage(driver);
        }
    }
}
