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
    public class FileDownloadPage(IWebDriver driver, WebDriverWait wait)
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = wait;

        //locators
        private readonly By mainPracticeButton = By.CssSelector("a[data-testid=\"navbar-practice\"]");
        private readonly By mainFileDownloadButton = By.CssSelector("div[data-testid=\"practice-file-download\"]");
        private readonly By fileDownloadButton = By.XPath("//button[text()='Download File']");


    //methods
        public FileDownloadPage MainPracticeButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainPracticeButton)).Click();
            return this;
        }
        public FileDownloadPage MainFileDownloadButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainFileDownloadButton)).Click();
            return this;
        }
        public FileDownloadPage FileDownloadButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(fileDownloadButton)).Click();
            return this;
        }
        public bool IsFileDownloadButtonPresent()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(fileDownloadButton)).Displayed;
        }
    }
}
