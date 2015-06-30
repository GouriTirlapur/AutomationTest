using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace AmazonTesting
{
    class BookDetailPage:BasePage
    {
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        IWebElement btnAddToCart;

        [FindsBy(How = How.ClassName, Using = "offer-price")]
        IWebElement txtPrice;

        public BookDetailPage(IWebDriver Driver)
            : base(Driver)
        {
            
        }

        public ShoppingCartPage clickAddToCart()
        {
            btnAddToCart.Click();
            ShoppingCartPage rsPage = new ShoppingCartPage(_driver);
            PageFactory.InitElements(_driver, rsPage);
            return rsPage;
        }

        public String getOfferPrice()
        {
            return txtPrice.Text;
        }
    }
}
