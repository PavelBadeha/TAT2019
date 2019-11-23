using OpenQA.Selenium;

namespace Dev_4
{
    /// <summary>
    /// Class for inbox page
    /// </summary>
    class MailInboxPage:PageObject
    {
        private By unreadMessagesCounterLocator = By.ClassName("msglist-title__counter");
        private By messageLocator = By.CssSelector(".js-messageline.messageline.messageline_unread");
        private By mainMailPageButtonLocator = By.CssSelector("[href*='http://m.mail.ru']");
        private IWebElement unreadMessagesCounter;
        private IWebElement unreadMessage;
        private IWebElement mainMailPageButton;

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
                unreadMessagesCounter = driver.FindElement(unreadMessagesCounterLocator);
                return unreadMessagesCounter.Text;
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
                unreadMessage = driver.FindElement(messageLocator);
                unreadMessage.Click();
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
            mainMailPageButton = driver.FindElement(mainMailPageButtonLocator);
            mainMailPageButton.Click();
            return new MainMailPage(driver);
        }
    }
}
