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
    class SearchResultPage:BasePage
    {
        [FindsBy(How = How.ClassName, Using ="s-access-detail-page")]
        IList<IWebElement> books;
        

        public SearchResultPage(IWebDriver Driver)
            : base(Driver)
        {

        }

        public BookDetailPage clickFirstBook()
        {
            if (books.Count > 0)
            {
                books[0].Click();
                BookDetailPage rsPage = new BookDetailPage(_driver);
                PageFactory.InitElements(_driver, rsPage);
                return rsPage;
            }
            return null;

        }
    }
}
