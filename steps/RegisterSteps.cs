using Selenium.PageObjects;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Steps
{
    public class RegisterSteps
    {
        public static void SetFirstName(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterSteps.FirstName).SendKeys(text);
        }

        public static void ClickSubmit(RemoteWebDriver driver)
        {
            driver.FindElement(RegisterPage.Submit).Click();
        }

        public static void SetLastName(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.LastName).SendKeys(text);
        }

        public static void SetEmailAddress(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.EmailAddress).SendKeys(text);
        }

        public static void SetPhone(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.Phone).SendKeys(text);
        }

        public static void ClickGenderMale(RemoteWebDriver driver)
        {
            driver.FindElement(RegisterPage.GenderMale).Click();
        }

        public static void ClickGenderFeMale(RemoteWebDriver driver)
        {
            driver.FindElement(RegisterPage.GenderFeMale).Click();
        }

        public static void SelectCountryByText(RemoteWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByText(text);
        }

        public static void SelectCountryByValue(RemoteWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByValue(value);
        }

        public static void SelectCountryByIndex(RemoteWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.Country)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthYearByText(RemoteWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByText(text);
        }

        public static void SelectDateOfBirthYearByValue(RemoteWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByValue(value);
        }

        public static void SelectDateOfBirthYearByIndex(RemoteWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthYear)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthMonthByText(RemoteWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByText(text);
        }

        public static void SelectDateOfBirthMonthByValue(RemoteWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByValue(value);
        }

        public static void SelectDateOfBirthMonthByIndex(RemoteWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthMonth)).SelectByIndex(index);
        }

        public static void SelectDateOfBirthDayByText(RemoteWebDriver driver, string text)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByText(text);
        }

        public static void SelectDateOfBirthDayByValue(RemoteWebDriver driver, string value)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByValue(value);
        }

        public static void SelectDateOfBirthDayByIndex(RemoteWebDriver driver, int index)
        {
            new SelectElement(driver.FindElement(RegisterPage.DateOfBirthDay)).SelectByIndex(index);
        }

        public static void SetPassword(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.Password).SendKeys(text);
        }

        public static void SetConfirmPassword(RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.ConfirmPassword).SendKeys(text);
        }
    }
}