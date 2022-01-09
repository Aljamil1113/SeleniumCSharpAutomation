
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace HandSpecElements
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();

        static IWebElement textBox;

        static IWebElement checkBox;

        static void Main()
        {
            //*********TEXTBOX ELEMENTS***********//
            /*
            string url = "https://testing.todorvachev.com/text-input-field/";
            driver.Navigate().GoToUrl(url);
            textBox = driver.FindElement(By.Name("username"));
            textBox.SendKeys("Test text!");
            Thread.Sleep(3000);
            Console.WriteLine(textBox.GetAttribute("value"));
            Console.WriteLine(textBox.GetAttribute("maxlength"));
            Thread.Sleep(5000);
            driver.Quit(); */

            //*************CHECKBOX******//
            string url = "https://testing.todorvachev.com/check-button-test-3/";
            string option = "1";

            driver.Navigate().GoToUrl(url);

            checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
            checkBox.Click();
           
            
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
