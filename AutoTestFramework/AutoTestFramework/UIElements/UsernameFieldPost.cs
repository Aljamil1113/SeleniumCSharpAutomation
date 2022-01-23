using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AutoTestFramework.UIElements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > nav > div.mh-col-1-2.mh-post-nav-item.mh-post-nav-prev > a > p")]
        public IWebElement LoginFormLink{ get; set; }
    }
}
