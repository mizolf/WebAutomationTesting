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
    public class LoginToPageTestCase : MainCase
    {
        [Test]
        public void LoginToPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.nabava.net/");

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement cookieModal = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("CybotCookiebotDialogBodyContentText")));
                cookieModal.FindElement(By.XPath("//button[text()='Deny']")).Click();
            }
            catch (NoSuchElementException)
            { }
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/header/div/div[1]/div"))).Click();
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.Name("username"))).Click();
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.Name("username"))).Clear();
            driver.FindElement(By.Name("username")).SendKeys("ruap1231@outlook.com");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("nGQf8ZOEi7");
            driver.FindElement(By.XPath("//div[@id='modal-login']/div/form/div[3]/label")).Click();
            driver.FindElement(By.Name("Submit")).Click();
            Thread.Sleep(2500);
            driver.FindElement(By.XPath("//div[@id='account']/p/a")).Click();
            Thread.Sleep(2500);
        }
    }
}