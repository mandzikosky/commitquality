using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
  public class ProductPage
  {
      //locators
      private readonly IWebDriver driver;
      private readonly WebDriverWait wait;
      private readonly By mainProductButton = By.CssSelector("a[data-testid=\"navbar-products\"]");
      private readonly By FilterBox= By.ClassName("filter-textbox");
      private readonly By FilterButton = By.CssSelector("button[data-testid=\"filter-button\"]");
      private readonly By productListTable = By.ClassName("product-list-table");
      private readonly By ResetButton = By.CssSelector("button[data-testid=\"reset-filter-button\"]");
      private readonly By ShowMoreButton = By.CssSelector("button[data-testid=\"show-more-button\"]");
      private readonly By AddaProductButton = By.CssSelector("a[data-testid=\"add-a-product-button\"]");

        public ProductPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        //methods
        public ProductPage MainProductButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(mainProductButton)).Click();
            return this;
        }
        public  ProductPage WriteTextInFilterBox (string textFilterBox)
      {
            wait.Until(ExpectedConditions.ElementIsVisible(FilterBox)).SendKeys(textFilterBox);
            return this;
        }
        public ProductPage ButtonFilter()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FilterButton)).Click();
            return this;
        }
        public List<string> GetFilteredProductNames()
        {
            var productNames = new List<string>();

            var rows = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(productListTable));
            foreach (var row in rows)
            {
                var nameCell = row.FindElement(By.CssSelector("td[data-testid='name']"));
                productNames.Add(nameCell.Text);
            }
            return productNames;
        }
        public ProductPage ButtonReset()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ResetButton)).Click();
            return this;
        }

        public ProductPage ButtonShowMore()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ShowMoreButton)).Click();
            return this;
        }
        public ProductPage ButtonAddAProduct()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(AddaProductButton)).Click();
            return this;
        }
    }
}
