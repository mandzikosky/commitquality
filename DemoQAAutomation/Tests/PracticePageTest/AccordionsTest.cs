using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class AccordionsTest : BaseTest
    {
        [Test]
        public void AccordionsAll()
        {
            _AccordionsPage.MainPracticeButton();
            Thread.Sleep(1000);
            _AccordionsPage.MainAccordionsButton();
            Thread.Sleep(1000);
            string expectedTitle = "CommitQuality - Test Automation Demo";
            string actualTitle = _Driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            _AccordionsPage.AccordionsOne();
            _AccordionsPage.AccordionsButtonOne();
            string doubleClickMeText = _AccordionsPage.AccordionsTextOne();
            Assert.That(doubleClickMeText, Is.EqualTo("Button double clicked"));

            Thread.Sleep(2000);
            _AccordionsPage.AccordionsTwo();
            Thread.Sleep(2000);
            _AccordionsPage.AccordionsButtonTwo();
            Thread.Sleep(2000);
            _AccordionsPage.AccordionsThree();
            Thread.Sleep(2000);
            _AccordionsPage.AccordionsButtonThree();
            Thread.Sleep(2000);


        }
    }
}
