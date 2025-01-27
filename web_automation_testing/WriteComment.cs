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
    public class WriteCommentTestCase : MainCase
    {
        [Test]
        public void WriteComment()
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

            driver.FindElement(By.LinkText("Foto")).Click();
            browserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Dronovi i oprema'])[1]/following::a[1]"))).Click();
            driver.FindElement(By.Id("pretrazi_po_rijecima")).Click();
            driver.FindElement(By.Id("pretrazi_po_rijecima")).Clear();
            driver.FindElement(By.Id("pretrazi_po_rijecima")).SendKeys("HAVIT FM TRANSMITTER");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector(".form_wrapper")).Submit();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Prijavi grešku'])[1]/following::a[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='comments']/div[5]")).Click();
            driver.FindElement(By.Id("komentar.autor")).Click();
            driver.FindElement(By.Id("komentar.autor")).Clear();
            driver.FindElement(By.Id("komentar.autor")).SendKeys("TEST123");
            driver.FindElement(By.Id("komentar.naslov")).Click();
            driver.FindElement(By.Id("komentar.naslov")).Clear();
            driver.FindElement(By.Id("komentar.naslov")).SendKeys("TEST123");
            driver.FindElement(By.XPath("//form[@id='proizvodCommand']/div[3]/div/div/div[3]")).Click();
            driver.FindElement(By.Id("komentar.dobreStrane")).Click();
            driver.FindElement(By.Id("komentar.dobreStrane")).Clear();
            driver.FindElement(By.Id("komentar.dobreStrane")).SendKeys("TEST123");
            driver.FindElement(By.Id("komentar.loseStrane")).Click();
            driver.FindElement(By.Id("komentar.loseStrane")).Clear();
            driver.FindElement(By.Id("komentar.loseStrane")).SendKeys("TEST123");
            driver.FindElement(By.Id("komentar.text")).Click();
            driver.FindElement(By.Id("komentar.text")).Clear();
            driver.FindElement(By.Id("komentar.text")).SendKeys("TEST123");
            driver.FindElement(By.XPath("//input[@value='Pošalji komentar']")).Click();
        }
    }
}