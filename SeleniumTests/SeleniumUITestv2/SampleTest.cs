﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumUITest
{
    /// <summary>
    // Lecture Notes.
    /// </summary>
    [TestClass]
    public class SampleTest
    {
        string email = "muhammed@email.com";
        IWebDriver driver;

        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Automatically register with selenium and test the results.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                driver.FindElement(By.ClassName("ico-register")).Click();
                driver.FindElement(By.Id("gender-male")).Click();
                driver.FindElement(By.Id("FirstName")).SendKeys("Muhammed");
                driver.FindElement(By.Id("LastName")).SendKeys("Eroglu");
                driver.FindElement(By.Id("Email")).SendKeys(email);
                driver.FindElement(By.Id("Password")).SendKeys("aaaaaaaaaaaaaaaa1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("aaaaaaaaaaaaaaaa1");
                driver.FindElement(By.Id("register-button")).Click();

                // Get the success message
                string message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");

                IWebElement emailElement = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailElement.Displayed);

                // Logout
                driver.FindElement(By.ClassName("ico-logout")).Click();

                //driver.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
