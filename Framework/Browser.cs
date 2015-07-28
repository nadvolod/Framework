using System.Security.Policy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework
{
    public static class Browser
    {
        private static IWebDriver _webDriver = new FirefoxDriver();
        private static string _baseUrl = "http://www.qtptutorial.net";

        public static ISearchContext Driver
        {
            get { return _webDriver; } 
        }

        public static string Title { get { return _webDriver.Title; } }

        public static void Goto(string url)
        {
            _webDriver.Navigate().GoToUrl(_baseUrl + url);
        }

        public static void Initialize()
        {
            Goto("");
        }

        public static void Close()
        {
            _webDriver.Close();
        }
    }
}