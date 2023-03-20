﻿using OpenQA.Selenium;
using SeleniumUITestv3.WebDriverExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUITestv2.Pages
{
    /// <summary>
    // Lecture notes
    /// </summary>
    public class RegisterPage
    {
        public static IWebDriver driver;
        public RegisterPage(IWebDriver driver)
        {
            RegisterPage.driver = driver;
        }

        public string getTitle()
        {
            return driver.Title;
        }

        // Page Objects

        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By firstname = By.Id("FirstName");
        public static readonly By lastname = By.Id("LastName");
        public static readonly By emailaddress = By.Id("Email");
        public static readonly By password = By.Id("Password");
        public static readonly By confirmPassword = By.Id("ConfirmPassword");
        public static readonly By registerButton = By.Id("register-button");

        public static readonly By result = By.ClassName("result");
        public static readonly By logout = By.Id("ico-logout");

        // Page Methods

        public void SelectMaleRadioButton()
        {
            //driver.FindElement(genderMale).Click();
            driver.Click(genderMale);
        }

        public void EnterFirstName(string value)
        {
            //driver.FindElement(firstname).SendKeys(value);
            driver.EnterText(firstname, value);
        }

        public void EnterLastName(string value)
        {
            //driver.FindElement(lastname).SendKeys(value);
            driver.EnterText(lastname, value);
        }

        public void EnterEmail(string value)
        {
            //driver.FindElement(emailaddress).SendKeys(value);
            driver.EnterText(emailaddress, value);
        }

        public void EnterPassword(string value)
        {
            //driver.FindElement(password).SendKeys(value);
            driver.EnterText(password, value);
        }

        public void EnterConfirmPassword(string value)
        {
            //driver.FindElement(confirmPassword).SendKeys(value);
            driver.EnterText(confirmPassword, value);
        }

        public void ClickRegisterButton()
        {
            //driver.FindElement(registerButton).Click();
            driver.Click(registerButton);
        }

        public string GetSuccessMessage()
        {
            //return driver.FindElement(result).Text;
            return driver.getText(result);
        }

        public bool IsEmailAccountDisplayed(string email)
        {
            //return driver.FindElement(By.XPath("//*[test()='" + email + "']")).Displayed;
            return driver.getTextWithValueDisplayed(email);
        }

        public void ClickLogoutButton()
        {
            driver.FindElement(logout).Click();
        }
    }
}
