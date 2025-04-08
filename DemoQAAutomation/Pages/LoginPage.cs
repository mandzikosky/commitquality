using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
    public class LoginPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;
        private readonly By mainLogButton = By.CssSelector("a[data-testid=\"navbar-login\"]");
        private readonly By usernameField = By.CssSelector("input[data-testid='username-textbox']");
        private readonly By passwordField = By.CssSelector("input[data-testid='password-textbox']");
        private readonly By loginButton = By.CssSelector("button[data-testid='login-button']");
        private readonly By MyAccButton = By.CssSelector("a[data-testid='navbar-account']");

        // Methods

        public LoginPage MainLogInButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainLogButton)).Click();
            return this;
        }
      
        public LoginPage WriteTextBoxUser(string username)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(usernameField)).SendKeys(username);
            return this;
        }

        public LoginPage WriteTextBoxPass(string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(passwordField)).SendKeys(password);
            return this;
        }

        public LoginPage ClickLogInButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(loginButton)).Click();
            return this;
        }

        public string textAccount()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(MyAccButton)).Text;
        }
    }
}


