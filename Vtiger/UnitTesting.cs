using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger
{
    [TestFixture]
    public class UnitTesting :Tests
    { 
        [Test]
        public void Test1()
        {
            
            driver.Url = url;
            Console.WriteLine(driver.Title);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            string url = "http://localhost:8888/";
            driver.Url = url;
            Console.WriteLine(driver.Title);
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            string url = "http://localhost:8888/";
            driver.Url = url;
            Console.WriteLine(driver.Title);
            Assert.Pass();
        }
        [Test]
        public void Test4()
        {
            string url = "http://localhost:8888/";
            driver.Url = url;
            Console.WriteLine(driver.Title);
            Assert.Pass();
        }
    }
}
