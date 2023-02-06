using Vtiger.Generic;
using Vtiger.ObjRepo;
using NUnit.Framework;

namespace Vtiger.Tests
{
    [TestFixture]
    public class LoginTest : BaseCls
    {
        [Test]
        [Category("Smoke"), Category("Regressing"), Category("LoginPage")]
        public void LoginTesting()
        {
            lgp = new LoginPage(driver);
            lgp.Login("admin", "admin");
            string title = lgp.title;
            Assert.AreEqual(title, driver.Title);
            Console.WriteLine(title);
        }

    }
}
