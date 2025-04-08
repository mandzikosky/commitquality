using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests.PracticePageTest
{
    public class FileDownloadTest : BaseTest
    {
        [Test]
        public void TestFileDownload()
        {
            _FileDownloadPage.MainPracticeButton();
            Thread.Sleep(1000);
            _FileDownloadPage.MainFileDownloadButton();
            Thread.Sleep(1000);
            _FileDownloadPage.FileDownloadButton();
            Thread.Sleep(2000);
            bool isButtonPresent = _FileDownloadPage.IsFileDownloadButtonPresent();
            Assert.IsTrue(isButtonPresent, "The 'Download File' button is not present.");
        }
    }
    // string expectedMessage = "File downloaded successfully!";
    // string actualMessage = _FileDownloadPage.GetDownloadSuccessMessage();
    //Assert.That(actualMessage, Is.EqualTo(expectedMessage), "The 'File downloaded successfully!' message was not displayed.");
}
    
    
    

