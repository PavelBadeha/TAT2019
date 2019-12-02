using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Dev_5
{
    /// <summary>
    /// Class of gmail letter page 
    /// </summary>
    class GmailLetterPage:PageObject
    {
        private By _replyButtonLocator = By.CssSelector(".ams.bkH");
        private By _replyTextFieldLocator = By.XPath("//div[@role='textbox']");
        private By _sendReplyButtonLocator = By.CssSelector(".T-I.J-J5-Ji.aoO.v7.T-I-atl.L3");
        private IWebElement _replyButton;
        private IWebElement _replyTextField;
        private IWebElement _sendReplyButton;

        private string _letterTitle ="Gmail";

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="driver"></param>
        public GmailLetterPage(IWebDriver driver) : base(driver) { }

        protected override void PageValidationCheck()
        {
            if (!_wait.Until(ExpectedConditions.TitleContains(_letterTitle)))
            {
                // throw new NoValidPageException("This no inbox page");
            }
        }
        public GmailLetterPage Reply(string replyMessage)
        {
            _replyButton = driver.GetIWebElementBy(_replyButtonLocator);
            _replyButton.Click();
            _replyTextField = driver.GetIWebElementBy(_replyTextFieldLocator);
            _replyTextField.SendKeys(replyMessage);
            _sendReplyButton = driver.GetIWebElementBy(_sendReplyButtonLocator);
            _sendReplyButton.Click();
            return this;
        }
    }
}
