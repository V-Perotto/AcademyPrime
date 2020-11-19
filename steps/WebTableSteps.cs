using OpenQA.Selenium.Support.Events;
using Selenium.PageObjects;

namespace Selenium.PageObjects
{
    public class WebTableSteps
    {
        public static bool EditIsEnabled(EventFiringWebDriver driver)
        {
            try
            {
                return driver.FindElement(WebTablePage.Edit).Enabled;
            }

            catch () 
            {

            }
        }
    }
}