using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProjectKitapYurdu
{
    public class Base
    {
        public static IWebDriver driver = new ChromeDriver(@"C:\Users\MSİ-NB\Source\Repos\TestProjectKitapYurdu\TestProjectKitapYurdu\Driver\");

        public static void SetUp()
        {
            driver.Navigate().GoToUrl("https://www.kitapyurdu.com/");
            driver.Manage().Window.Maximize();
        }

        public static void Search()
        {
            driver.FindElement(By.Id("search-input")).Click();
            driver.FindElement(By.Id("search-input")).SendKeys("roman");
            driver.FindElement(By.Id("search-input")).SendKeys(Keys.Enter);
        }


        public static void SelectProduct()
        {
            driver.FindElement(By.Id("product-448692")).Click();
          
        }
        
        public static void CartSteps()
        {
            driver.FindElement(By.CssSelector("#product-306815 img")).Click();
            driver.FindElement(By.CssSelector("#button-cart > span")).Click();
            driver.FindElement(By.Id("cart-items")).Click();
            //driver.FindElement(By.ClassName("mg - b - 5")).Click();
            //driver.FindElement(By.XPath("//*[@id='js - cart']k")).Click();
            driver.FindElement(By.Id("js-cart")).Click();
            driver.FindElement(By.Name("quantity")).Click();
            driver.FindElement(By.Name("quantity")).Clear();
            driver.FindElement(By.Name("quantity")).SendKeys("2");
            driver.FindElement(By.CssSelector(".fa fa-refresh green-icon")).Click();
            driver.FindElement(By.CssSelector(".fa fa-times red-icon")).Click();
        }


        public static void Close()
        {
            driver.Quit();
        }

    }
}
