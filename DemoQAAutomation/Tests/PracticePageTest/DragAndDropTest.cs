using DemoQAAutomation.Pages.PracticePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class DragAndDropTest : BaseTest
    {
        [Test]
        public void TestDragAndDrop()
        {
           _DragAndDropPage.MainPracticeButton();
            _DragAndDropPage.MainDragAndDropButton();
            _DragAndDropPage.DragElement();
            string expectedMessage = "Success!";
            string actualMessage = _DragAndDropPage.DropElementText();
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "The 'Success!' message was not displayed.");



        }
    }
    
}
