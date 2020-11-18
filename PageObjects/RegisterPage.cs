using OpenQA.Selenium;

namespace Selenium.PageObjects
{
    public class RegisterPage
    {
        public static By FirstName = By.XPath("//input[@placeholder='First Name']");
        public static By Submit = By.XPath("//button[@id='submitbtn']");
        public static By LastName = By.XPath("//input[@placeholder='Last Name']");
        public static By EmailAddress = By.XPath("//input[@type='email']");
        public static By Phone = By.XPath("//input[@type='tel']");
        public static By GenderMale = By.XPath("//input[@value='Male']");
        public static By GenderFeMale = By.XPath("//input[@value='Female']");
        public static By Country = By.XPath("//select[@id='countries']");
        public static By DateOfBirthYear = By.XPath("//select[@id='yearbox']");
        public static By DateOfBirthMonth = By.XPath("//select[@placeholder='Month']");
        public static By DateOfBirthDay = By.XPath("//select[@id='daybox']");
        public static By Password = By.XPath("//input[@id='firstpassword']");
        public static By ConfirmPassword = By.XPath("//input[@id='secondpassword']");
    }
}