
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace SizeAndPosition
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Size size = new Size();
            size.Width =  600;
            size.Height = 600;

            Point position = new Point();
            position.X = -10;
            position.Y = -10;

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = size;
            driver.Manage().Window.Position = position;

            driver.Navigate().GoToUrl("http://testing.todvachev.com");
        }
    }
}
