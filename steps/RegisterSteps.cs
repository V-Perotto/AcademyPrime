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
            driver.FindElement(RegisterSteps.FirstName).SendKeys(text);
        }

        public static void ClickSubmit(EventFiringWebDriver driver)
        {
            driver.FindElement(RegisterPage.Submit).Click();
        }

        public static void SetLastName(EventFiringWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.LastName).SendKeys(text);
        }

        public static void SetEmailAddress(EventFiringWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.EmailAddress).SendKeys(text);
        }

        public static void SetPhone(EventFiringWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.Phone).SendKeys(text);
        }

        public static void ClickGenderMale(EventFiringWebDriver driver)
        {
            driver.FindElement(RegisterPage.GenderMale).Click();
        }

        public static void ClickGenderFeMale(EventFiringWebDriver driver)
        {
            driver.FindElement(RegisterPage.GenderFeMale).Click();
        }

        public static void SelectCountryByText(EventFiringWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByText(text);
        }

        public static void SelectCountryByValue(EventFiringWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByValue(value);
        }

        public static void SelectCountryByIndex(EventFiringWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthYearByText(EventFiringWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByText(text);
        }

        public static void SelectDateOfBirthYearByValue(EventFiringWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByValue(value);
        }

        public static void SelectDateOfBirthYearByIndex(EventFiringWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthMonthByText(EventFiringWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByText(text);
        }

        public static void SelectDateOfBirthMonthByValue(EventFiringWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByValue(value);
        }

        public static void SelectDateOfBirthMonthByIndex(EventFiringWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthDayByText(EventFiringWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByText(text);
        }

        public static void SelectDateOfBirthDayByValue(EventFiringWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByValue(value);
        }

        public static void SelectDateOfBirthDayByIndex(EventFiringWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByIndex(index);
        }

        public static void SetPassword(EventFiringWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.Password).SendKeys(text);
        }

        public static void SetConfirmPassword(EventFiringWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.ConfirmPassword).SendKeys(text);
        }
    }
}