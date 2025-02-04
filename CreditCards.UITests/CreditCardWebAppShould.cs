﻿using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreditCards.UITests
{
    public class CreditCardWebAppShould
    {
        private const string homeUrl = "https://www.retail-int.com/";
        private const string homeTitle = "Home Page - Credit Cards";
        private const string aboutUrl = "http://localhost:44108/Home/About"; 

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(homeUrl);
              
                DemoHelper.Pause();

                //Assert.Equal(homeTitle, driver.Title);
                Assert.Equal(homeUrl, driver.Url);
            }
        }

    //    [Fact]
    //    [Trait("Category", "Smoke")]
    //    public void ReloadApplicationPage()
    //    {
    //        using (IWebDriver driver = new ChromeDriver())
    //        {
    //            driver.Navigate().GoToUrl(homeUrl);

    //            DemoHelper.Pause();

    //            driver.Navigate().Refresh();
    //            Assert.Equal(homeTitle, driver.Title);
    //            Assert.Equal(homeUrl, driver.Url);
    //        }
    //    }
    //    [Fact]
    //    [Trait("Category", "Smoke")]
    //    public void ReloadHomePageOnBackward()
    //    {
    //        using (IWebDriver driver = new ChromeDriver())
    //        {
    //            driver.Navigate().GoToUrl(homeUrl);
    //            IWebElement generationTokenElement =
    //               driver.FindElement(By.Id("GenerationToken"));
    //            string initialToken = generationTokenElement.Text;
    //            DemoHelper.Pause();

    //            driver.Navigate().GoToUrl(aboutUrl);
    //            DemoHelper.Pause();

    //            driver.Navigate().Back();
    //            DemoHelper.Pause();

    //            Assert.Equal(homeTitle, driver.Title);
    //            Assert.Equal(homeUrl, driver.Url);

    //            string reloadedToken = driver.FindElement(By.Id("GenerationToken")).Text;
    //            Assert.NotEqual(initialToken, reloadedToken);
    //        }
    //    }

    //    [Fact]
    //    [Trait("Category", "Smoke")]
    //    public void ReloadHomePageOnForward()
    //    {
    //        using (IWebDriver driver = new ChromeDriver())
    //        {
    //            driver.Navigate().GoToUrl(homeUrl);
    //            DemoHelper.Pause();

    //            driver.Navigate().Refresh();
    //            Assert.Equal(homeTitle, driver.Title);
    //            Assert.Equal(homeUrl, driver.Url);
    //        }
    //    }
    }
}
