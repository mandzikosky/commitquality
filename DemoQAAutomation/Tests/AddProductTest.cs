using DemoQAAutomation.Pages;
using NUnit.Framework;
using System.Threading;

namespace DemoQAAutomation.Tests
{
    public class AddProductTest : BaseTest
    {
        [Test]
        public void AddProductFieldBox()
        {
            _AddProductPage.NavAddButton();
            string productName = "Brille";
            string priceProduct = "186";
            string dateStockedPro = "02/04/2025";

            _AddProductPage.NameField(productName);
            Thread.Sleep(4000);
            _AddProductPage.PriceField(priceProduct);
            Thread.Sleep(4000);
            _AddProductPage.FieldDateStocked(dateStockedPro);
            Thread.Sleep(4000);
            _AddProductPage.SubmitButton();
            Thread.Sleep(4000);

            // Validate the product name in the product list
            bool isProductAdded = _AddProductPage.IsProductInList(productName);
            Assert.That(isProductAdded, $"Product '{productName}' was not found in the product list.");
        }
    }
}

