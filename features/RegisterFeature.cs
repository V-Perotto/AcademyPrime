using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Selenium.features
{
    [TestClass]
    public class RegisterFeature : TestBase
    {
        [TestMethod]
        public void SkipSignInComSucesso()
        {     
            #region Scenario
            IndexSteps.ClickSkipSignIn(driver);
            Assert.IsTrue(driver.Url.Contains("Register"), "Sign In realizado com sucesso");
            #endregion
        }

        public static IEnumerable<object[]> GetData()
        {
            var randomNumber = new Random().Next(10000000, 99999999).ToString(); 
            yield return new object[] { "Vittorio", "Perotto", "v-perotto@test.com", $"41{randomNumber}", "Brazil", "2002", 5, "14", "Testing@123", "Testing@123" }
        }

        [TestMethod]
        [DynamicData("GetData", DynamicDataSourceType.Method)]
        public void CadastroComSucesso(string firstName, string lastName, string email, string telefone, string pais, string ano, int mes, string dia, string senha, string confirmaSenha)
        {
            #region Scenario
            IndexSteps.ClickSkipSignIn(driver);
            RegisterSteps.SetFirstName(driver, firstName);
            RegisterSteps.SetLastName(driver, lastName);
            RegisterSteps.SetEmailAddress(driver, email);
            RegisterSteps.SetPhone(driver, telefone);
            RegisterSteps.SetGenderMale(driver);
            RegisterSteps.SetCountryByText(driver, pais);
            RegisterSteps.SetDathOfBirthYearByText(driver, ano);
            RegisterSteps.SetDathOfBirthMonthByText(driver, mes);
            RegisterSteps.SetDathOfBirthDayByText(driver, dia);
            RegisterSteps.SetPassword(driver, senha);
            RegisterSteps.SetConfirmPassword(driver, confirmaSenha);
            RegisterSteps.ClickSubmit(driver);

            Assert.IsTrue(WebTableSteps.EditIsEnabled(driver));
            #endregion
        }

        [TestMethod]
        public void CadastroComFalha()
        {

        }
    }
}