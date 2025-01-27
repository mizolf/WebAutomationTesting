using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTests
{
    [TestFixture]
    public class NavigatePriceHistoryTestcase : MainCase
    {

        [Test]
        public void NavigatePriceHistory()
        {
            driver.Navigate().GoToUrl("https://www.nabava.net/");
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement cookieModal = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("CybotCookiebotDialogBodyContentText")));
                cookieModal.FindElement(By.XPath("//button[text()='Deny']")).Click();
            }
            catch (NoSuchElementException)
            { }
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]")).Click();
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/div[3]")).Click();
            driver.FindElement(By.XPath("//div[@class='price-history__period' and text()='Mjesec dana']")).Click();
            Thread.Sleep(5000);
        }

        public void WaitForPageToLoad(IWebDriver driver, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(driver =>
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                return js.ExecuteScript("return document.readyState").ToString() == "complete";
            });
        }
    }
}
