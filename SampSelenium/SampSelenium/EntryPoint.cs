
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;

namespace SampSelenium
{
    class EntryPoint
    {
        static void Main()
        {
            //IWebDriver driver = new FirefoxDriver();

            //driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            //Thread.Sleep(3000);

            //driver.Quit();
        
            //****************SELECTORS***************//
            IWebDriver driver = new ChromeDriver();

            //string url = "http://testing.todorvachev.com/selectors/name/";
            //string url = "http://testing.todorvachev.com/selectors/id/";
            //string url = "http://testing.todorvachev.com/selectors/class-name/";
            string url = "https://testing.todorvachev.com/css-path/";
            string cssPath = "#post-108 > div > figure > img";
            string xPath = "//*[@id=\"post-108\"]/div/figure/img";

            driver.Navigate().GoToUrl(url);

            //IWebElement element = driver.FindElement(By.Name("myName"));
            //IWebElement element = driver.FindElement(By.Id("testImage"));
            //IWebElement element = driver.FindElement(By.ClassName("testClass"));

            try
            {
                IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));

                if (cssPathElement.Displayed)
                {
                    GreenMessage("Yes! I can see the element, it's right there!!! (" + cssPathElement.Text + ").");
                }
            }
            catch (Exception)
            {
                RedMessage("Well, something went wrong, I couldn't see the element!");
            }


            try
            {
                IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

                if (xPathElement.Displayed)
                {
                    GreenMessage("Yes! I can see the element, it's right there!!! (" + xPathElement.Text + ").");
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("Well, something went wrong, I couldn't see the element!");
            }
            
            Thread.Sleep(5000);

            driver.Quit();
        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
