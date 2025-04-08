using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class ContactUsFormTest : BaseTest
    {
        [Test]
        public void ContactUsForm()
        {
            string name = "Tommy";
            string email = "tommy@yahoo.com";
            DateOnly dateOfBirth = new(1998, 1, 12);
          

            _ContactUsFormPage.MainPracticeButton();
            Thread.Sleep(1000);
            _ContactUsFormPage.MainContactUsButton();
            Thread.Sleep(1000);
            string expectedTitle = "CommitQuality - Test Automation Demo";
            string actualTitle = _Driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            _ContactUsFormPage.NameInputField(name);
            Thread.Sleep(1000);
            _ContactUsFormPage.EmailInputField(email);
            Thread.Sleep(1000);
            _ContactUsFormPage.QueryTypeButton();
            Thread.Sleep(1000);
            _ContactUsFormPage.QueryTypeOption();
            Thread.Sleep(1000);
            _ContactUsFormPage.DateOfBirth(dateOfBirth);
            Thread.Sleep(1000);
            _ContactUsFormPage.CheckBoxButton();
            Thread.Sleep(1000);
            _ContactUsFormPage.SubmitButton();
            Thread.Sleep(1000);
            string expectedMessage = "Thanks for contacting us, we will never respond!";
            string actualMessage = _ContactUsFormPage.SuccessMessage();
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "The success message was not displayed as expected.");
        }

    }

    
}
