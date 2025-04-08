using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class PopUpTest : BaseTest
    {
        [Test]
        public void PopUpAll()
        {
            _PopUpPage.MainPracticeButton();
            Thread.Sleep(3000);
            _PopUpPage.MainPopUpButton();
            Thread.Sleep(3000);
            Assert.IsTrue(_PopUpPage.IsPopupDisplayed(), "The popup is not displayed.");
            _PopUpPage.PopUpButton();
            Thread.Sleep(3000);
        }
    }
    
    
}
