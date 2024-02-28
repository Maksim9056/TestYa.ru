using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace TestYa.ru
{
    public class Tests
    {
        /// <summary>
        /// Test web-site ya.ru open and quit
        /// </summary>
        [Test]
        public void TesT()
        {
            var chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(@"C:\chromedriver-win64\", chromeOptions);

            driver.Navigate().GoToUrl("https://ya.ru");


            driver.Quit();
        }
    }
}