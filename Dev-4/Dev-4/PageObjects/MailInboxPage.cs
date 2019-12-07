using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class for inbox page
    /// </summary>
    class MailInboxPage:PageObject
    {
        private By _unreadMessagesCounterLocator = By.Id("g_mail_events");
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
            _unreadMessagesCounter = driver.FindElement(_unreadMessagesCounterLocator);
            _unreadMessage = driver.FindElement(_messageLocator);
            _mainMailPageButton = driver.FindElement(_mainMailPageButtonLocator);
        }

        /// <summary>
        /// Method that returns count of unread messages
        /// </summary>
        /// <returns></returns>
        public int GetUnreadMessagesCount()
        {
            return int.Parse(_unreadMessagesCounter.Text);
        }

        /// <summary>
        /// Method that reads unread message
        /// </summary>
        public void ReadUnreadMessage()
        {              
            _unreadMessage.Click();
            driver.Navigate().Back();
        }

        /// <summary>
        /// Method that navigates to main page
        /// </summary>
        /// <returns>Maine page</returns>
        public MainMailPage NavigateToMainMailPage()
        {
            _mainMailPageButton.Click();
            return new MainMailPage(driver);
        }
    }
}
