using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Dev_5
{
    /// <summary>
    /// Class for inbox page
    /// </summary>
    class MailInboxPage : PageObject
    {
        private By _unreadMessagesCounterLocator = By.Id("g_mail_events");
        private By _messageLocator = By.XPath("//div[@class='llc__item llc__item_correspondent llc__item_unread']");
        private By _sendMessageButtonLocator = By.XPath("//span[@class='compose-button__wrapper']");
        private By _recipientEmailFiedLocator = By.CssSelector(".container--H9L5q.size_s--3_M-_");
        private By _sendMessageFieldLocator = By.XPath(".//div[@role='textbox']/div/div[1]");
        private By _confirmationOfSendingMessageButtonLocator = By.CssSelector(".button2.button2_base.button2_primary.button2_compact.button2_hover-support.js-shortcut");
        private IWebElement _unreadMessagesCounter;
        private IWebElement _unreadMessage;
        private IWebElement _sendMessageButton;
        private IWebElement _sendMessageField;
        private IWebElement _recipientEmailField;
        private IWebElement _confirmationOfSendingMessageButton;

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
            if (!_wait.Until(ExpectedConditions.TitleContains(InboxTitle[0])) && 
                !_wait.Until(ExpectedConditions.TitleContains(InboxTitle[1])))
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
            _unreadMessagesCounter = driver.GetIWebElementBy(_unreadMessagesCounterLocator);
            return _unreadMessagesCounter.Text;
        }

        /// <summary>
        /// Method that reads unread message
        /// </summary>
        public void ReadUnreadMessage()
        {
            if (int.Parse(GetUnreadMessagesCount()) > 0) 
            {
                _unreadMessage = driver.GetIWebElementBy(_messageLocator);
                Thread.Sleep(500);
                _unreadMessage.Click();
                
                if( _wait.Until(ExpectedConditions.TitleIs("Почта Mail.ru")))
                {
                    driver.Navigate().Back();
                }
            }
        }

        public void SendMessage(string recipientEmail, string message)
        {
            _sendMessageButton = driver.GetIWebElementBy(_sendMessageButtonLocator);
            _sendMessageButton.Click();

            _recipientEmailField = driver.GetIWebElementBy(_recipientEmailFiedLocator);
            _recipientEmailField.SendKeys(recipientEmail);

            _sendMessageField = driver.GetIWebElementBy(_sendMessageFieldLocator);
            _sendMessageField.SendKeys(message);

            _confirmationOfSendingMessageButton = driver.GetIWebElementBy(_confirmationOfSendingMessageButtonLocator);
            _confirmationOfSendingMessageButton.Click();
            var closeButton = driver.GetIWebElementBy(By.CssSelector(".button2.button2_has-ico.button2_close.button2_pure.button2_clean.button2_short.button2_hover-support"));
            closeButton.Click();
        }
    }
}
