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
    public class GenaralComponentsPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;
        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainGeneralComponentsButton = By.CssSelector("div[data-testid=\"practice-general\"]");
        //BUTTONS
        private readonly By clickMeButton = By.CssSelector("button[data-testid=\"basic-click\"]");
        private readonly By doubleClickMeButton = By.CssSelector("button[data-testid=\"double-click\"]");
        private readonly By rightClickMeButton = By.CssSelector("button[data-testid=\"right-click\"]");
        private readonly By clickMeParagraph = By.XPath("//button[@data-testid='basic-click']/following-sibling::p");
        private readonly By doubleClickMeParagraph = By.XPath("//button[@data-testid='double-click']/following-sibling::p");
        private readonly By rightClickMeParagraph = By.XPath("//button[@data-testid='right-click']/following-sibling::p");
        //RADIO BUTTONS
        private readonly By radioButtonOne = By.CssSelector("input[data-testid=\"option1\"");
        private readonly By radioButtonTwo = By.CssSelector("input[data-testid=\"option2\"]");
        private readonly By optionOne = By.XPath("//input[@data-testid='option1']/ancestor::div[@class='component-container']//p");
        private readonly By optionTwo = By.XPath("//input[@data-testid='option2']/ancestor::div[@class='component-container']//p");
        //SELECT AN OPTION
        private readonly By clickDropDown = By.CssSelector("div[data-testid=\"dropdown\"]");
        private readonly By selectOptionTwo = By.CssSelector("option[value=\"option2\"]");

        //CHECKBOXES
        private readonly By checkBoxOne = By.CssSelector("input[data-testid=\"checkbox1\"]");
        private readonly By checkBoxTwo = By.CssSelector("input[data-testid=\"checkbox2\"]");
        private readonly By checkBoxThree = By.CssSelector("input[data-testid=\"checkbox3\"]");
        private readonly By checkBoxOneText = By.XPath("//input[@data-testid='checkbox1']/following-sibling::p");
        private readonly By checkBoxTwoText = By.XPath("//input[@data-testid='checkbox2']/following-sibling::p");
        private readonly By checkBoxThreeText = By.XPath("//input[@data-testid='checkbox3']/following-sibling::p");

        //LINKS
        private readonly By myYoutube = (By.CssSelector("a[data-testid=\"link-same-tab\"]"));
        private readonly By cookiesButton = By.CssSelector("button[aria-label='Accept all']");
        



        public GenaralComponentsPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public GenaralComponentsPage MainGeneralComponenetsButtonTop()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainGeneralComponentsButton)).Click();
            return this;
        }
        
        //BUTTONS
        public GenaralComponentsPage ClickMeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clickMeButton)).Click();
            return this;
        }
        public string GetClickMeParagraphText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(clickMeParagraph)).Text;
        }

        public GenaralComponentsPage DoubleClickMeButton()
        {
            var doubClick = wait.Until(ExpectedConditions.ElementIsVisible(doubleClickMeButton));
            Actions actions = new Actions(driver);
            actions.DoubleClick(doubClick).Perform();
            return this;
        }
        public string GetDoubleClickMeParagraphText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(doubleClickMeParagraph)).Text;
        }
        public GenaralComponentsPage RightClickMeButton()
        {
            var rightClick = wait.Until(ExpectedConditions.ElementIsVisible(rightClickMeButton));
            Actions actions = new Actions(driver);
            actions.ContextClick(rightClick).Perform();
            return this;
        }

        public string GetRightClickMeParagraphText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(rightClickMeParagraph)).Text;
        }

        //RADIO BUTTONS

        public GenaralComponentsPage RadioButtonOne()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(radioButtonOne)).Click();
            return this;
        }
        public GenaralComponentsPage RadioButtonTwo()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(radioButtonTwo)).Click();
            return this;
        }
        public string GetOptionOneText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(optionOne)).Text;
        }
        public string GetOptionTwoText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(optionTwo)).Text;
        }

        //SELECT AN OPTION

        public GenaralComponentsPage SelectAnOption()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clickDropDown)).Click();
            return this;
        }

        public GenaralComponentsPage SelectAnOptionTwo()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectOptionTwo)).Click();
            return this;
        }

        //CHECKBOXES
        public GenaralComponentsPage CheckBoxOne()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxOne)).Click();
            return this;
        }
        public GenaralComponentsPage CheckBoxTwo()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxTwo)).Click();
            return this;
        }
        public GenaralComponentsPage CheckBoxThree()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(checkBoxThree)).Click();
            return this;
        }
        public string GetCheckBoxOneText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(checkBoxOneText)).Text;
        }
        public string GetCheckBoxTwoText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(checkBoxTwoText)).Text;
        }
        public string GetCheckBoxThreeText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(checkBoxThreeText)).Text;
        }

        // LINKS

   

        public GenaralComponentsPage MyYoutube()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(myYoutube)).Click();
            return this;
        }

        public GenaralComponentsPage CookiesButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(cookiesButton)).Click();
            return this;
        }

        public string GetYoutubeText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(myYoutube)).GetAttribute("href");
        }



    }
}
