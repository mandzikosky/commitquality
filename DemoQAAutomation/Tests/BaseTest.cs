using DemoQAAutomation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using DemoQAAutomation.Tests.PracticePageTest;
using DemoQAAutomation.Pages.PracticePage;


namespace DemoQAAutomation.Tests
{
    public class BaseTest
    {
        protected IWebDriver _Driver { get; private set; }
        protected WebDriverWait _Wait { get; private set; }
        protected ProductPage _ProductPage { get; private set; }
        protected LoginPage _LoginPage { get; private set; }
        protected AddProductPage _AddProductPage { get; private set; }
        protected GenaralComponentsPage _GeneralComponentsPage { get; private set; }
        protected AccordionsPage _AccordionsPage { get; private set; }
        protected PopUpPage _PopUpPage { get; private set; }
        protected DragAndDropPage _DragAndDropPage { get; private set; }
        protected FileDownloadPage _FileDownloadPage { get; private set; }
        protected ContactUsFormPage _ContactUsFormPage { get; private set; }

        [SetUp]
        public void SetUp()
        {
            _Driver = new ChromeDriver();
            _Wait = new(_Driver, TimeSpan.FromSeconds(20));

            _Driver.Manage().Window.Maximize();
            _Driver.Navigate().GoToUrl("https://commitquality.com/");

            //_Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            _ProductPage = new ProductPage(_Driver, _Wait);
            _LoginPage = new LoginPage(_Driver, _Wait);
            _AddProductPage = new AddProductPage(_Driver, _Wait);
            _GeneralComponentsPage = new GenaralComponentsPage(_Driver, _Wait);
            _AccordionsPage = new AccordionsPage(_Driver, _Wait);
            _PopUpPage = new PopUpPage(_Driver, _Wait);
            _DragAndDropPage = new DragAndDropPage(_Driver, _Wait);
            _FileDownloadPage = new FileDownloadPage(_Driver, _Wait);
            _ContactUsFormPage = new ContactUsFormPage(_Driver, _Wait);

        }
        [TearDown]
        public void TearDown()
        {
            _Driver.Dispose();
            _Driver.Quit();
            
        }

        public void Sleep(int seconds)
        {
            Sleep(seconds * 1000);
        }
    }
}