using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace DemoQAAutomation.Pages.PracticePage
{
    public class AccordionsPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;

        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainAccordionsButtton = By.CssSelector("div[data-testid=\"practice-accordions\"]");
        private readonly By accordionsButtonOne = By.CssSelector("button[data-testid='accordion-1']:nth-of-type(1)");
        private readonly By insideAccOne = By.CssSelector("button[data-testid=\"double-click\"]");
        private readonly By insideAccOneText = By.XPath("//button[@data-testid='double-click']/following-sibling::p");
        private readonly By accordionsButtonTwo = By.CssSelector("button[data-testid='accordion-1']:nth-of-type(2)");
        private readonly By insideAccTwo = By.CssSelector("input[data-testid=\"option2\"]");
        private readonly By accordionsButtonThree = By.CssSelector("button[data-testid='accordion-1']:nth-of-type(3)");
        private readonly By insideAccThree = By.CssSelector("input[data-testid=\"checkbox2\"]");

        //methods

        public AccordionsPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public AccordionsPage MainAccordionsButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainAccordionsButtton)).Click();
            return this;
        }
        public AccordionsPage AccordionsOne()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(accordionsButtonOne)).Click();
            return this;
        }
        public AccordionsPage AccordionsButtonOne()
        {
            var doubleClick = wait.Until(ExpectedConditions.ElementIsVisible(insideAccOne));
            Actions actions = new Actions(driver);
            actions.DoubleClick(doubleClick).Perform();
            return this;
        }
        public string AccordionsTextOne()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(insideAccOneText)).Text;
        }
        public AccordionsPage AccordionsTwo()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(accordionsButtonTwo)).Click();
            return this;
        }
        public AccordionsPage AccordionsButtonTwo()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(insideAccTwo)).Click();
            return this;
        }
        public AccordionsPage AccordionsThree()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(accordionsButtonThree)).Click();
            return this;
        }
        public AccordionsPage AccordionsButtonThree()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(insideAccThree)).Click();
            return this;
        }

    }
}
