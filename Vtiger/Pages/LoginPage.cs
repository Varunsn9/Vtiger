using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;

namespace Vtiger.ObjRepo
{
    [TestFixture]
    public class LoginPage
    {
        public string url = "http:localhost:8888";
        public string title = "vtiger CRM 5 - Commercial Open Source CRM";

        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement usernametb { get; set; }

        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement passwordtb { get; set; }

        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement loginbtn { get; set; }




        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            driver.Url = url;
        }
        public void Login(string username, string password)
        {
            usernametb.SendKeys(username);
            passwordtb.SendKeys(password);
            loginbtn.Click();
        }

    }
}
