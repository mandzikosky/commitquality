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
    public class PopUpPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;

        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainPopUpButton = By.CssSelector("div[data-testid=\"practice-random-overlay\"]");
        private readonly By popUpButton = By.ClassName("overlay-content");
        private readonly By overlayContent = By.CssSelector("div.overlay-content");
        


        //methods

        public PopUpPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public PopUpPage MainPopUpButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPopUpButton)).Click();
            return this;
        }
        public PopUpPage PopUpButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(popUpButton)).Click();
            return this;
        }
        public bool IsPopupDisplayed()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(overlayContent)).Displayed;
        }
    }
}
