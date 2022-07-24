using System;
using Xunit;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestProjectKitapYurdu
{
    public class UnitTest1
    {
        private IWebDriver driver = Base.driver;


        [Fact]
        public void KitapYurduTest()
        {
            
           Base.SetUp();

            //driver.FindElement(By.Id("search-input")).Click();
            //driver.FindElement(By.Id("search-input")).SendKeys("roman");
            //driver.FindElement(By.Id("search-input")).SendKeys(Keys.Enter);
           Base.Search();

            //driver.FindElement(By.CssSelector("#button-cart > span")).Click();
            //driver.FindElement(By.Id("cart-items")).Click();
            //driver.FindElement(By.Id("js-cart")).Click();
            //driver.FindElement(By.Name("quantity")).Click();
            //driver.FindElement(By.Name("quantity")).SendKeys("2");
            //driver.FindElement(By.CssSelector(".fa-refresh")).Click();
            //driver.FindElement(By.CssSelector(".red-icon")).Click();
            Base.CartSteps();

            Base.Close();
        }


    }
}
