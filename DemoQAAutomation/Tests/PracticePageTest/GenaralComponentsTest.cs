using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class GeneralComponentsTest : BaseTest
    {

        [Test]

        public void GeneralComponentsAll()
        {
            _GeneralComponentsPage.MainPracticeButton();
            Thread.Sleep(1000);
            _GeneralComponentsPage.MainGeneralComponenetsButtonTop();
            Thread.Sleep(1000);
            string expectedTitle = "CommitQuality - Test Automation Demo";
            string actualTitle = _Driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            // Validate the title of the page

            // BUTTONS
            // Click the "Click me" button and validate the text
            _GeneralComponentsPage.ClickMeButton();
            Thread.Sleep(2000);
            string clickMeText = _GeneralComponentsPage.GetClickMeParagraphText();
            Assert.That(clickMeText, Is.EqualTo("Button clicked"));

            // Double-click the "Double click me" button and validate the text
            _GeneralComponentsPage.DoubleClickMeButton();
            Thread.Sleep(2000);
            string doubleClickMeText = _GeneralComponentsPage.GetDoubleClickMeParagraphText();
            Assert.That(doubleClickMeText, Is.EqualTo("Button double clicked"));

            // Right-click the "Right click me" button and validate the text
            _GeneralComponentsPage.RightClickMeButton();
            Thread.Sleep(3000);
            string rightClickMeText = _GeneralComponentsPage.GetRightClickMeParagraphText();
            Assert.That(rightClickMeText, Is.EqualTo("Button right mouse clicked"));

            //RADIO BUTTONS
            _GeneralComponentsPage.RadioButtonOne();
            Thread.Sleep(2000);
            string radioButtonOneText = _GeneralComponentsPage.GetOptionOneText();
            Assert.That(radioButtonOneText, Is.EqualTo("option1 clicked"));
            _GeneralComponentsPage.RadioButtonTwo();
            Thread.Sleep(2000);
            string radioButtonTwoText = _GeneralComponentsPage.GetOptionTwoText();
            Assert.That(radioButtonTwoText, Is.EqualTo("option2 clicked"));

            //SELECT AN OPTION
            _GeneralComponentsPage.SelectAnOption();
            Thread.Sleep(2000);
            _GeneralComponentsPage.SelectAnOptionTwo();
            Thread.Sleep(2000);

            //CHECKBOXES
            _GeneralComponentsPage.CheckBoxOne();
            Thread.Sleep(2000);
            string checkBoxOneText = _GeneralComponentsPage.GetCheckBoxOneText();
            Assert.That(checkBoxOneText, Is.EqualTo("Checkbox 1 checked"));
            _GeneralComponentsPage.CheckBoxTwo();
            Thread.Sleep(2000);
            string checkBoxTwoText = _GeneralComponentsPage.GetCheckBoxTwoText();
            Assert.That(checkBoxTwoText, Is.EqualTo("Checkbox 2 checked"));
            _GeneralComponentsPage.CheckBoxThree();
            Thread.Sleep(2000);
            string checkBoxThreeText = _GeneralComponentsPage.GetCheckBoxThreeText();
            Assert.That(checkBoxThreeText, Is.EqualTo("Checkbox 3 checked"));

            //LINKS

            _GeneralComponentsPage.MyYoutube();
            Thread.Sleep(2000);
            _GeneralComponentsPage.CookiesButton();
            Thread.Sleep(2000);
            string expectedyoutubeTitle = "https://www.youtube.com/@commitquality";
            string actualyoutubeTitle = _Driver.Url;
            Assert.That(actualyoutubeTitle, Is.EqualTo(expectedyoutubeTitle));
            _Driver.Navigate().GoToUrl("https://commitquality.com/practice-general-components");
            Thread.Sleep(3000);
            string expectedTitlee = "CommitQuality - Test Automation Demo";
            string actualTitlee = _Driver.Title;
            Assert.That(actualTitlee, Is.EqualTo(expectedTitlee));


        }


    }


    }

