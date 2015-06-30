using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AmazonTesting
{
    [Binding]
    public class BaseStepDefinition
    {
        public static IWebDriver Driver { get; set; }
    }
}
