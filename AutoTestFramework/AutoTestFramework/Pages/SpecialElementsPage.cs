using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class SpecialElementsPage
    {
        public SpecialElementsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
