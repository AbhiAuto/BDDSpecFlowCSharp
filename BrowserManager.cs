using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ConsoleApplication2
{
    [Binding]
    class BrowserManager
    {
        public static IWebDriver driver;
        public static IWebDriver BrowserDriver()
        {
            driver = new ChromeDriver(@"c:\Users\u65557\Documents\Visual Studio 2015\Projects\BDDFramework\ConsoleApplication2\Drivers\");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return driver;
        }

        public static IWebDriver getCurrentDriver()
        {
            return driver;
        }
    }

    
}
