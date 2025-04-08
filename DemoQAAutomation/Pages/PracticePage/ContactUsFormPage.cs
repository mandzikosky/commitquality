using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace DemoQAAutomation.Pages.PracticePage
{
    public class ContactUsFormPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;

        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainContactUsButton = By.CssSelector("div[data-testid=\"practice-contact-form\"]");
        private readonly By nameInputField = By.CssSelector("input[data-testid='name']");
        private readonly By emailInputField = By.CssSelector("input[data-testid='email']");
        private readonly By queryTypeButton = By.CssSelector("select[data-testid=\"query-type\"]");
        private readonly By queryTypeOption = By.XPath("//option[text()='General']");
        private readonly By dateOfBirthField = By.CssSelector("input[data-testid=\"dob\"]");
        private readonly By checkBoxButton = By.CssSelector("input[data-testid=\"practice-checkbox\"]");
        private readonly By submitButton = By.CssSelector("button[data-testid=\"submit-button\"]");
        private readonly By successMessage = By.CssSelector("div.success-message");

        //methods
        public ContactUsFormPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public ContactUsFormPage MainContactUsButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainContactUsButton)).Click();
            return this;
        }
        public ContactUsFormPage NameInputField(string name)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(nameInputField)).SendKeys(name);
            return this;
        }
        public ContactUsFormPage EmailInputField(string email)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(emailInputField)).SendKeys(email);
            return this;
        }
        public ContactUsFormPage QueryTypeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(queryTypeButton)).Click();
            return this;
        }
        public ContactUsFormPage QueryTypeOption()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(queryTypeOption)).Click();
            return this;
        }
        public ContactUsFormPage DateOfBirth(DateOnly dateOfBirth)
        {
           
            var dateOfBirthForemated = dateOfBirth.ToString("dd/M/yyyy");
            wait.Until(ExpectedConditions.ElementIsVisible(dateOfBirthField)).SendKeys(dateOfBirthForemated);
            return this;
        }
        public ContactUsFormPage CheckBoxButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxButton)).Click();
            return this;
        }
        public ContactUsFormPage SubmitButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(submitButton)).Click();
            return this;
        }
        public string SuccessMessage()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(successMessage)).Text;
        }
    }

}
