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
        private By _messageLocator = By.CssSelector(".llc__item_unread");
        private By _mainMailPageButtonLocator = By.CssSelector("[href*='http://mail.ru']");
        private By _sendMessageButtonLocator = By.ClassName("compose-button__wrapper");
        private By _recipientEmailFiedLocator = By.CssSelector(".container--H9L5q.size_s--3_M-_");
        private By _sendMessageFieldLocator = By.XPath(".//div[@role='textbox']/div/div[1]");
           // ("/html/body/div[16]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div/div[1]");
        private By _confirmationOfSendingMessageButtonLocator = By.CssSelector(".button2.button2_base.button2_primary.button2_compact.button2_hover-support.js-shortcut");
        private IWebElement _unreadMessagesCounter;
        private IWebElement _unreadMessage;
        private IWebElement _mainMailPageButton;
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
            _unreadMessagesCounter = _wait.Until(ExpectedConditions.ElementIsVisible(_unreadMessagesCounterLocator));
            return _unreadMessagesCounter.Text;
        }

        /// <summary>
        /// Method that reads unread message
        /// </summary>
        public void ReadUnreadMessage()
        {
            if (int.Parse(GetUnreadMessagesCount()) > 0) 
            {
                _unreadMessage = _wait.Until(ExpectedConditions.ElementIsVisible(_messageLocator));
                _unreadMessage.Click();
                
                if( _wait.Until(ExpectedConditions.TitleIs("Почта Mail.ru")))
                {
                    driver.Navigate().Back();
                }
            }
        }

        public void SendMessage(string recipientEmail, string message)
        {
            _sendMessageButton = _wait.Until(ExpectedConditions.ElementIsVisible(_sendMessageButtonLocator));
            Thread.Sleep(500);
            _sendMessageButton.Click();

            _recipientEmailField = _wait.Until(ExpectedConditions.ElementIsVisible(_recipientEmailFiedLocator));
            _recipientEmailField.SendKeys(recipientEmail);

            _sendMessageField = _wait.Until(ExpectedConditions.ElementIsVisible(_sendMessageFieldLocator));
            _sendMessageField.SendKeys(message);

            _confirmationOfSendingMessageButton = _wait.Until(ExpectedConditions.ElementIsVisible(_confirmationOfSendingMessageButtonLocator));
            Thread.Sleep(1000);
            _confirmationOfSendingMessageButton.Click();
        }

        /// <summary>
        /// Method that navigates to main page
        /// </summary>
        /// <returns>Maine page</returns>
        public MainMailPage NavigateToMainMailPage()
        {
            _mainMailPageButton =  driver.FindElement(_mainMailPageButtonLocator);
            _mainMailPageButton.Click();
            return new MainMailPage(driver);
        }
    }
}
