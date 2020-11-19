using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Selenium
{   
    public class TestBase
    {
        public ChromeDriver chromeDriver;
        public static string Report;
        private TestContext testContext;
        public EventFiringWebDriver driver;

        public TestContext
        {
            get
            {
                return testContext;
            }
            set
            {
                testContext = value;
            }
        }

        public void Log(string Report, string msg) 
        {
            using(StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine(msg);      
            }
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            #region report
            var directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestsResults")

            if (!Directory.Exists(directory)) 
            {
                Directory.CreateDirectory(directory);
            }
            Report = Path.Combine(directory, $"{TestContext.TestName}{DateTime.Now:ddMMyyyyThhmmss}.txt");
            
            Log(Report, TestContext.TestName);

            chromeDriver = new ChromeDriver(@"C:\Users\Vittorio Perotto\Desktop\SeleniumC#\AcademyPrime\Selenium");
            driver = new EventFiringWebDriver(chromeDriver); 
            #endregion

            #region Initialize
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.automationtesting.in/Index.html";
            
            driver.FindElementCompleted += Driver_FindElementCompleted;
            // driver.ElementClicked += Driver_ElementClicked;
            // driver.ElementValueChanged += Driver_ElementValueChanged;
            driver.ExceptionThrown += Driver_ElementThrown;
            driver.ElementClicking += Driver_ElementClicking;
            driver.ElementValueChanging += Driver_ElementValueChanging;
            #endregion
        } 

        public void Driver_ElementThrown(object sender, WebDriverExceptionEventArgs e) 
        {
            using(StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"{e.ThrownException.Message}\n{e.ThrownException.InnerException}\n{e.ThorwnException.StackTrace}");
                sw.WriteLine("------------------------------------------");
            }
        }

        public void Driver_ElementValueChanging(object sender, WebElementValueEventArgs e) 
        {
            using(StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"Elemento com valor alterado pelo identificador {e.Element}");
                sw.WriteLine("------------------------------------------");
            }
        }

        public void Driver_ElementClickin(object sender, WebElementEventArgs e) 
        {
            using(StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"Elemento clicado pelo identificador {e.Element}");
                sw.WriteLine("------------------------------------------");
            }
        }

        public void Driver_FindElementCompleted(object sender, FindElementEventArgs e) 
        {
            using(StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine("------------------------------------------");
                sw.WriteLine($"Elemento Encontrado pelo identificador {e.FindMethod}");
                sw.WriteLine("------------------------------------------");
            }
        }

        [TestCleanup]
        public void MyTestCleanup() 
        {
            driver.Quit();
            TestContext.AddResultFile(Report);
        }
    }
}