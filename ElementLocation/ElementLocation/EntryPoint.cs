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
            
            IWebElement image = driver.FindElement(By.CssSelector(".alignnone"));

            driver.Manage().Window.Maximize();

            Console.WriteLine(image.Location.X);
            Console.WriteLine(image.Location.Y);
            Console.WriteLine(image.Size.Width);
            Console.WriteLine(image.Size.Height);
            

            //driver.Quit();
        }

        
    }
}
