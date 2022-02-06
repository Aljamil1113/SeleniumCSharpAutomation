using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ElementLocation
{
    public class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            string url = "http://testing.todvachev.com";

            driver.Navigate().GoToUrl(url);

            //IWebElement image = driver.FindElement(By.CssSelector(".alignnone"));

            //driver.Manage().Window.Maximize();

            //Console.WriteLine(image.Location.X);
            //Console.WriteLine(image.Location.Y);
            //Console.WriteLine(image.Size.Width);
            //Console.WriteLine(image.Size.Height);


            IWebElement content = driver.FindElement(By.CssSelector("#main-content"));

            SetStyle(driver, content, "color", "green");

            //driver.Quit();
        }

        static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            jsExecutor.ExecuteScript(script, element);
        }
    }
}
