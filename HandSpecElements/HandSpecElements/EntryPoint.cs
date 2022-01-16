
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

        static IWebElement radioButton;

        static IWebElement dropDownMenu;

        static IWebElement elementFromDropdownMenu;

        static IAlert alert;

        static IWebElement image;

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
            /*
            string url = "https://testing.todorvachev.com/check-button-test-3/";
            string option = "1";

            driver.Navigate().GoToUrl(url);

            checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
            checkBox.Click();
           
            
            Thread.Sleep(5000);
            driver.Quit(); */

            //*************RADIOBUTTON*********//
            /*
            string url = "https://testing.todorvachev.com/radio-button-test/";
            string [] option = { "1", "3", "5" };

            driver.Navigate().GoToUrl(url);

            for (int i = 0; i < option.Length; i++)
            {

                radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child( " + option[i] + " )"));

                if (radioButton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("This radio button is checked!");
                }
                else
                {
                    Console.WriteLine("This is one of the unchecked radio buttons");
                    radioButton.Click();
                }
            }

            driver.Quit(); */


            //*************DROPDOWN************//
            /*
            string url = "https://testing.todorvachev.com/drop-down-menu-test/";

            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine(dropDownMenu.GetAttribute("value"));

            elementFromDropdownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine(elementFromDropdownMenu);

            elementFromDropdownMenu.Click();

            Console.WriteLine(dropDownMenu.GetAttribute("value"));

            for (int i = 1; i <= 4; i++)
            { 
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child( " + i + " )";

                elementFromDropdownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

                Console.WriteLine("The {0} option from the drop down menu is {1}.", i, elementFromDropdownMenu.GetAttribute("value"));
            }

            Thread.Sleep(20000);

            driver.Quit(); */

            //*************ALERT BOX************//
            string url = "https://testing.todorvachev.com/alert-box/";

            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();

            Console.WriteLine(alert.Text);

            alert.Accept();

            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

            try
            {
                if(image.Displayed)
                {
                    Console.WriteLine("The alert was successfully accepted and I can see the image.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }

            Thread.Sleep(20000);

            driver.Quit();

        }
    }
}
