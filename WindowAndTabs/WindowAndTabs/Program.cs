
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WindowAndTabs
{
    class Program
    {
        static void Main()
        {
            List<string> handles = new List<string>();
            IWebDriver driver = new ChromeDriver();

            IWebElement newTab;
            IWebElement newWindow;

            string url = "https://testing.todorvachev.com/new-tab/";
            string newTabsSelector = ".entry-content > p:nth-child(1) > a:nth-child(1)";
            string newWindowSelector = ".entry-content > p:nth-child(1) > a:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            newTab = driver.FindElement(By.CssSelector(newTabsSelector));
            newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

            newTab.Click();

            handles = driver.WindowHandles.ToList();

            IWebElement usernameBox = driver.FindElement(By.Name("username"));

            usernameBox.SendKeys("selenium");

            Thread.Sleep(1000);

            driver.SwitchTo().Window(handles[1]);

            System.Console.WriteLine(driver.CurrentWindowHandle);
            System.Console.WriteLine(driver.CurrentWindowHandle);

            IWebElement searchBox1 = driver.FindElement(By.Name("q"));
            searchBox1.SendKeys("Selenium");


        }
    }
}
