using OpenQA.Selenium;

namespace Selenium.steps
{
    public class IndexSteps
    {
        public static void ClickSkipSignIn(this EventFiringWebDriver driver)
        {
            TestBase.Log(TestBase.Report, "Clique no botão 'Skip Sign In'");
            driver.FindElement(IndexPage.SkipSignIn).Click();
        }
    }
}