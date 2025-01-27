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
    public class AddNotificationForProductTestCase : MainCase
    {
        [Test]
        public void AddNotificationForProduct()
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
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Savjeti'])[1]/following::div[1]")).Click();
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.Name("username"))).Click();
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.Name("username"))).Clear();
            driver.FindElement(By.Name("username")).SendKeys("ruap1231@outlook.com");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("nGQf8ZOEi7");
            driver.FindElement(By.XPath("//div[@id='modal-login']/div/form/div[3]/label")).Click();
            driver.FindElement(By.Name("Submit")).Click();
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("Apple MacBook Pro 14\" mw2u3d/a, 3024x1964, 512GB SSD, 16GB RAM, Apple Mac OS");
            driver.FindElement(By.CssSelector(".header__search-form")).Submit();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Stavi u listu želja'])[1]/following::div[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("userAlertStrikePrice")).Click();
            driver.FindElement(By.Id("userAlertStrikePrice")).Clear();
            driver.FindElement(By.Id("userAlertStrikePrice")).SendKeys("500");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("save-user-alert")).Click();
            Thread.Sleep(1000);
            acceptNextAlert = true;
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ukloni iz liste želja'])[1]/following::div[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("delete-user-alert")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Obriši obavijest[\\s\\S]$"));
            Thread.Sleep(2000);
        }
    }
}