using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Vtiger.ObjRepo;
using NUnit.Framework;

namespace Vtiger.Generic
{

    public class BaseCls
    {
        public IWebDriver driver;
        public LoginPage lgp;

        [SetUp]
        public void openBrowser()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
