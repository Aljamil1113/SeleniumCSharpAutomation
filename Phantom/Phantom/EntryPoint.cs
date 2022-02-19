using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System;

namespace PhantomJS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> postLinksList = new List<string>();

            List<string> extractedTitle = new List<string>();
            List<string> extractedContent = new List<string>();

            int startUndexOfLink, lengthOfLink;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            IWebDriver driver = new ChromeDriver(options);
            IWebElement titleElement;
            IWebElement contentElement;

            IAlert alert;

            string url = "https://testing.todorvachev.com/sitemap-posttype-post.xml";

            string titleSelector = "#main-content > article > header > h1";
            string contentSelector = "#main-content > article > div";

            driver.Navigate().GoToUrl(url);
            string[] PageSource = driver.PageSource.Split(' ');

            foreach (var item in PageSource)
            {

                if(item.Contains(@"href=""https://testing.todorvachev.com/"))
                {
                    startUndexOfLink = item.IndexOf(@"href=\", StringComparison.CurrentCulture) + 7;
                    lengthOfLink = item.LastIndexOf(@""">", StringComparison.CurrentCulture) - startUndexOfLink;

                    postLinksList.Add(item.Substring(startUndexOfLink, lengthOfLink));
                }
            }

            foreach (var item in postLinksList)
            {
                if (item.Equals("https://testing.todorvachev.com/alert-box/"))
                {
                    continue;
                }
                driver.Navigate().GoToUrl(item);

                titleElement = driver.FindElement(By.CssSelector(titleSelector));
                contentElement = driver.FindElement(By.CssSelector(contentSelector));

                extractedTitle.Add(titleElement.Text);
                extractedContent.Add(contentElement.Text);
            }
        }
    }
}
