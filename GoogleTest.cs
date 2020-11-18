using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AulaSeleniumWeb
{
    [Test Class]
    public class GoogleTest
    {
        [Test Method]
        public void TestePesquisar()
        {
            var driver = new ChromeDriver(@"C:\Selenium");

            try 
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Url = "https://www.google.com.br";
                driver.FindElementByXPath("//input[@name='q']").SendKeys("carros" + Keys.Enter);

                Assert.IsTrue(driver.FindElementByXPath("//a[text()='Shopping']").Enabled);
            }

            catch(Exception e)
            {
                driver.quit();
                Assert.Fail($"{e.Message}/n{e.InnerException}/n{e.StackTrace}");
            }
            driver.quit();
        }
    }
}

// Template