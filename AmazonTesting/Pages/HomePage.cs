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
    class HomePage:BasePage
    {

        
        [FindsBy(How = How.Id,Using="twotabsearchtextbox")]
            IWebElement textbox;
        [FindsBy(How = How.CssSelector,Using ="input[value='Go']")]
        IWebElement searchBox;

        public HomePage(IWebDriver Driver)
                      : base(Driver)
        {
        }

        public SearchResultPage searchbook(string bookName )
        {
            textbox.SendKeys(bookName);
            searchBox.Click();
            SearchResultPage rsPage = new SearchResultPage(_driver);
            PageFactory.InitElements(_driver,rsPage);
            return rsPage;
        }

    }
}
