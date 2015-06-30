using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace AmazonTesting
{
    [Binding]
    public class AmazonBookSearchSteps:BaseStepDefinition
    {

        [Given(@"a user has searched a (.*)")]
         public void GivenAUserHasSearchedABook(String bookName)
        {
            Driver.Navigate().GoToUrl("http://www.amazon.com/");
            HomePage homePage = new HomePage(Driver);
            PageFactory.InitElements(Driver, homePage);
            SearchResultPage searchResultPage = homePage.searchbook(bookName);
            BookDetailPage bookDetailPage = searchResultPage.clickFirstBook();
            ScenarioContext.Current.Add("BookDetailPage", bookDetailPage);
        }

        [When(@"he clicks add to cart button")]
        public void WhenHeClicksAddToCartButton()
        {
            BookDetailPage bookDetailPage = (BookDetailPage) ScenarioContext.Current["BookDetailPage"];
            ScenarioContext.Current.Add("BookPrice", bookDetailPage.getOfferPrice());
            ShoppingCartPage shoppingCartPage = bookDetailPage.clickAddToCart();
            ScenarioContext.Current.Add("ShoppingCartPage", shoppingCartPage);
        }

        [Then(@"book should be added to the shopping cart\.")]
        public void ThenBookShouldBeAddedToTheShoppingCart_()
        {
            ShoppingCartPage shoppingCartPage = (ShoppingCartPage)ScenarioContext.Current["ShoppingCartPage"];
            shoppingCartPage.verifyBookAddedToCart((string)ScenarioContext.Current["BookPrice"]);
        }
    }
}
