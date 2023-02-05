using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Vtiger
{
    public class Tests
    {
       public IWebDriver driver;
       public string url = "http://localhost:8888/";

        [SetUp]
        public void Setup()
        {
            driver=new ChromeDriver();
            
        }

        
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}