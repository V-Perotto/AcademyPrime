using Selenium.PageObjects;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Steps
{
    public class RegisterSteps
    {
        // Ctrl + H  > para substituir todas as variaveis com um nome igual
        public static void SetFirstName(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys primeiro nome: {text}");
            driver.FindElement(RegisterSteps.FirstName).SendKeys(text);
        }

        public static void ClickSubmit(EventFiringWebDriver driver)
        {
            TestBase.Log(TestBase.Report, $"Clique no botão Submit: {text}");
            driver.FindElement(RegisterPage.Submit).Click();
        }

        public static void SetLastName(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys sobrenome: {text}");
            driver.FindElement(RegisterPage.LastName).SendKeys(text);
        }

        public static void SetEmailAddress(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys email: {text}");
            driver.FindElement(RegisterPage.EmailAddress).SendKeys(text);
        }

        public static void SetPhone(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys telefone: {text}");
            driver.FindElement(RegisterPage.Phone).SendKeys(text);
        }

        public static void ClickGenderMale(EventFiringWebDriver driver)
        {
            TestBase.Log(TestBase.Report, $"Clique no botão 'Masculino': {text}");
            driver.FindElement(RegisterPage.GenderMale).Click();
        }

        public static void ClickGenderFeMale(EventFiringWebDriver driver)
        {
            TestBase.Log(TestBase.Report, $"Clique no botão 'Feminino': {text}");
            driver.FindElement(RegisterPage.GenderFeMale).Click();
        }

        public static void SelectCountryByText(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"Selecione o país por texto: {text}");
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByText(text);
        }

        public static void SelectCountryByValue(EventFiringWebDriver driver, string value)
        {
            TestBase.Log(TestBase.Report, $"Selecione o país por valor: {text}");
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByValue(value);
        }

        public static void SelectCountryByIndex(EventFiringWebDriver driver, int index)
        {
            TestBase.Log(TestBase.Report, $"Selecione o país por index: {text}");
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthYearByText(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"Selecione o ano da data de nascimento por texto: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByText(text);
        }

        public static void SelectDateOfBirthYearByValue(EventFiringWebDriver driver, string value)
        {
            TestBase.Log(TestBase.Report, $"Selecione o ano da data de nascimento por valor: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByValue(value);
        }

        public static void SelectDateOfBirthYearByIndex(EventFiringWebDriver driver, int index)
        {
            TestBase.Log(TestBase.Report, $"Selecione o ano da data de nascimento por index: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthMonthByText(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"Selecione o mês da data de nascimento por texto: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByText(text);
        }

        public static void SelectDateOfBirthMonthByValue(EventFiringWebDriver driver, string value)
        {
            TestBase.Log(TestBase.Report, $"Selecione o mês da data de nascimento por valor: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByValue(value);
        }

        public static void SelectDateOfBirthMonthByIndex(EventFiringWebDriver driver, int index)
        {
            TestBase.Log(TestBase.Report, $"Selecione o mês da data de nascimento por index: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthDayByText(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"Selecione o dia da data de nascimento por texto: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByText(text);
        }

        public static void SelectDateOfBirthDayByValue(EventFiringWebDriver driver, string value)
        {
            TestBase.Log(TestBase.Report, $"Selecione o dia da data de nascimento por valor: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByValue(value);
        }

        public static void SelectDateOfBirthDayByIndex(EventFiringWebDriver driver, int index)
        {
            TestBase.Log(TestBase.Report, $"Selecione o dia da data de nascimento por index: {text}");
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByIndex(index);
        }

        public static void SetPassword(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys senha: {text}");
            driver.FindElement(RegisterPage.Password).SendKeys(text);
        }

        public static void SetConfirmPassword(EventFiringWebDriver driver, string text)
        {
            TestBase.Log(TestBase.Report, $"SendKeys confirmando a senha: {text}");
            driver.FindElement(RegisterPage.ConfirmPassword).SendKeys(text);
        }
    }
}