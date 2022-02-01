using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace AutoTestFramework
{
    public class TestCasePage
    {
        public TestCasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#main-content > " +
            "article.mh-loop-item.mh-clearfix.post-76.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases " +
            "> div > header > h3 > a")]
        public IWebElement UsernameField{ get; set; }
    }
}
