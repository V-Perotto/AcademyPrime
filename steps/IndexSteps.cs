using OpenQA.Selenium;

namespace Selenium.steps
{
    public class IndexSteps
    {
        public static void ClickSkipSignIn(this EventFiringWebDriver driver)
        {
            driver.FindElement(IndexPage.SkipSignIn).Click();
        }
    }
}