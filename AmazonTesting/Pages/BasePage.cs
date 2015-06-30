using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AmazonTesting
{
    public class BasePage
    {
       public static IWebDriver _driver;

        public BasePage (IWebDriver Driver)
        {
            _driver = Driver;
        }
    }
}
