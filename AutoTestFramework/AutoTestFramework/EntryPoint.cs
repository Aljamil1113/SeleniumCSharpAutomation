using AutoTestFramework.UIElements;
using System.Threading;

namespace AutoTestFramework
{
    public class EntryPoint
    {
        static void Main()
        {
            //Menu menu = new Menu();

            //Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            //menu.Selectors.Click();

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            NavigateTo.LoginFormThroughTheMenu();

            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            NavigateTo.LoginFormThroughThenPost();

            Thread.Sleep(500);

            Driver.driver.Quit();
        }
    }
}
