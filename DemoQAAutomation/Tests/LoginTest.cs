using DemoQAAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests
{
    public class LoginTest : BaseTest
    {

        [Test]
        public void WriteTextBoxUserPassTest()
        {
            var username = "test";
            var password = "test";
            string textAccount = "My Account";

           
            //_LoginPage.MainLogInButton().WriteTextBoxUser(username).WriteTextBoxPass(password).ClickLogInButton();
            //Thread.Sleep(3000);

            _LoginPage.MainLogInButton();
            Thread.Sleep(3000);
           // Sleep(3);


            _LoginPage.WriteTextBoxUser(username);
            Thread.Sleep(3000);
            //Sleep(3);

           _LoginPage.WriteTextBoxPass(password);
            Thread.Sleep(3000);
            //Sleep(3);

            _LoginPage.ClickLogInButton();
            Thread.Sleep(3000);
            //Sleep(3);

            
            Assert.That(textAccount, Is.EqualTo("My Account"));

        }
    }
}
