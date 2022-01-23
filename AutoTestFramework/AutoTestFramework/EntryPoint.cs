

using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public class EntryPoint
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            menu.Selectors.Click();
        }
    }
}
