using DemoQAAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumExtras.PageObjects;


namespace DemoQAAutomation.Tests
{
    public class ProductsFilterTest : BaseTest
    {
        [Test]



        public void WriteTextInFilterBoxTest()

        {
            var filterText = "Product 2";
            _ProductPage.MainProductButton();
            Thread.Sleep(3000);

            _ProductPage.WriteTextInFilterBox(filterText);
            Thread.Sleep(3000);

            _ProductPage.ButtonFilter();
            Thread.Sleep(3000);

            var filteredProductNames = _ProductPage.GetFilteredProductNames();
            Assert.That(filteredProductNames, Contains.Item("Product 2"), "Product 'Product 2' was not found in the product list.");

            _ProductPage.ButtonReset();
            Thread.Sleep(3000);

            _ProductPage.ButtonShowMore();
            Thread.Sleep(3000);

            _ProductPage.ButtonAddAProduct();
            Thread.Sleep(3000);

            string expectedTitle = "CommitQuality - Test Automation Demo";
            string actualTitle = _Driver.Title;
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

            _Driver.Navigate().Back();
            Thread.Sleep(3000);
        }

    }
    }


