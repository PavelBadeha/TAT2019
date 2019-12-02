using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Dev_5
{
    /// <summary>
    /// Class of gmail inbox page
    /// </summary>
    class GmailInboxPage:PageObject
    {
        public string[] InboxTitle { get; } = new string[] { "Входящие", "Gmail" };
        private By _messageFromSenderLocator;
        private IWebElement _messageFromSender;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public GmailInboxPage(IWebDriver driver) : base(driver) { }
        protected override void PageValidationCheck()
        {
            if (!_wait.Until(ExpectedConditions.TitleContains(InboxTitle[0])) &&
                !_wait.Until(ExpectedConditions.TitleContains(InboxTitle[1])))
            {
                throw new NoValidPageException("This no inbox page");
            }
        }

        /// <summary>
        /// Method that read letter from some email
        /// </summary>
        /// <param name="senderEmail">email of sender</param>
        /// <returns>gmail letter page</returns>
        public GmailLetterPage ReadMessageFrom(string senderEmail)
        {
            _messageFromSenderLocator = By.XPath($"//tr[.//span[@email='{senderEmail}']]");
            _messageFromSender = driver.GetIWebElementBy(_messageFromSenderLocator);
            _messageFromSender.Click();
            return new GmailLetterPage(driver);
        }
    }
}
