using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Selenium.features
{
    [TestClass]
    public class RegisterFeature
    {
        [TestMethod]
        public void SkipSignInComSucesso()
        {
            var driver = new ChromeDriver(@"C:\Selenium");

            try 
            {
                #region Initialize
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Url = "http://demo.automationtesting.in/Index.html";
                #endregion

                #region Scenario
                IndexSteps.ClickSkipSignIn(driver);
                Assert.IsTrue(driver.Url.Contains("Register"), "Sign In realizado com sucesso");
                #endregion
            }

            catch(Exception e)
            {
                driver.quit();
                Assert.Fail($"{e.Message}/n{e.InnerException}/n{e.StackTrace}");
            }
            driver.quit();
        }

        [TestMethod]
        public void CadastroComSucesso()
        {
            var driver = new ChromeDriver(@"C:\Selenium");

            try 
            {
                #region Initialize
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "http://demo.automationtesting.in/Index.html";
                #endregion

                #region Scenario
                IndexSteps.ClickSkipSignIn(driver);
                RegisterSteps.SetFirstName(driver, "Vittorio");
                RegisterSteps.SetLastName(driver, "Perotto");
                RegisterSteps.SetEmailAddress(driver, "v-perotto@test.com");
                RegisterSteps.SetPhone(driver, "4199999999");
                RegisterSteps.SetGenderMale(driver);
                RegisterSteps.SetCountryByText(driver, "Brazil");
                RegisterSteps.SetDathOfBirthYearByText(driver, "2002");
                RegisterSteps.SetDathOfBirthMonthByText(driver, 5);
                RegisterSteps.SetDathOfBirthDayByText(driver, "14");
                RegisterSteps.SetPassword(driver, "Testing@123");
                RegisterSteps.SetConfirmPassword(driver, "Testing@123");
                RegisterSteps.ClickSubmit(driver);
                #endregion
            }

            catch(Exception e)
            {
                driver.quit();
                Assert.Fail($"{e.Message}/n{e.InnerException}/n{e.StackTrace}");
            }
            driver.quit();
        }

        [TestMethod]
        public void CadastroComFalha()
        {

        }
    }
}