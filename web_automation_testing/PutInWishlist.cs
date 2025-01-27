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
    public class PutInWishlistTestcase : MainCase
    {

        [Test]
        public void PutInWishlist()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("https://www.nabava.net/");
            driver.FindElement(By.Name("q")).Click();
            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("Logitech G 715");
            driver.FindElement(By.CssSelector(".header__search-form")).Submit();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Logitech G715 bežični tipkovnica, bijela'])[2]/following::div[4]")).Click();
            driver.FindElement(By.XPath("/html/body/header/div/div[1]/a[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Postavi obavijest o cijeni'])[1]/following::div[1]")).Click();
            Thread.Sleep(1000);
        }
    }
}
