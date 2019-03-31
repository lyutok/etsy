using G2_AutomationFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EtsyAutomationTests.Pages
{
    class EtsySearchPage : BasePage
    {
        public EtsySearchPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'v2-listing-card__info') and not (contains(@class, 'flex'))]//h2")]
        public System.Collections.Generic.IList<IWebElement> searchResultsItems; 
              
    }
}
