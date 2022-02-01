using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public class Driver
    {
        public IWebDriver driver { get; set; }

        public void WaitForElementUpTo(int seconds = 5)
        {
        }
    }
}
