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
    class ShoppingCartPage:BasePage
    {
        [FindsBy(How = How.Id, Using = "confirm-text")]
        IList<IWebElement> txtConfirm2;

        [FindsBy(How = How.Id, Using = "huc-v2-order-row-confirm-text")]
        IList<IWebElement> txtConfirm1;

        [FindsBy(How = How.ClassName, Using = "hlb-price")]
        IWebElement txtPrice;

        public ShoppingCartPage(IWebDriver Driver):base(Driver)
        {

        }

        public void verifyBookAddedToCart(string Price)
        {
            //Assert.AreEqual("Added to Cart", txtConfirm[0].Text);
            if (txtConfirm1.Count > 0)
            {
                Assert.True(txtConfirm1[0].Text.Contains("Added to Cart"));
            }else if(txtConfirm2.Count > 0){
                Assert.True(txtConfirm2[0].Text.Contains("added to Cart"));
            }
            else
            {
                Console.WriteLine ("Book - Add to cart failed");
            }
            
            Assert.AreEqual(Price, txtPrice.Text);

        }
    }
}
