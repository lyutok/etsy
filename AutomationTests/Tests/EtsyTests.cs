using EtsyAutomationTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using G2_AutomationFramework.Utils;
using System.Threading;

namespace EtsyAutomationTests.Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestSearch()
        {
            var searchText = "Men's Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();
            // Thread.Sleep(2000);

            EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

            foreach (var textItem in etsySearchPage.searchResultsItems)
            {
                Console.WriteLine(textItem.Text
                Assert.True(textItem.Text.Contains(searchText));
             //   Console.WriteLine(textItem.Text.Trim());
            }
        }
    }
}