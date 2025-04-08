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
    public class DragAndDropPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;

        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainDragAndDropButton = By.CssSelector("div[data-testid=\"practice-drag-drop\"]");
        private readonly By dragElement = By.CssSelector("div[data-testid='small-box']");
        private readonly By dropElement = By.CssSelector("div[data-testid='large-box']");
        private readonly By dropElementText = By.CssSelector("div[data-testid='large-box']");

        //methods
        public DragAndDropPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public DragAndDropPage MainDragAndDropButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainDragAndDropButton)).Click();
            return this;
        }
        public DragAndDropPage DragElement()
        {
            var dragElement = wait.Until(ExpectedConditions.ElementIsVisible(this.dragElement));
            var dropElement = wait.Until(ExpectedConditions.ElementIsVisible(this.dropElement));
           // var dropElementText = wait.Until(ExpectedConditions.ElementIsVisible(this.dropElementText));
            Actions actions = new Actions(driver);
            actions.DragAndDrop(dragElement, dropElement).Perform();
            return this;
        }
        public string DropElementText()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(dropElementText)).Text;
        }
       
    }
}
