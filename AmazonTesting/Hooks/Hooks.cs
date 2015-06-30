using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace AmazonTesting
{
    [Binding]
    public class Hooks:BaseStepDefinition
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
        [BeforeFeature]
        public static void BeforeFeature()
        {

            Driver = new FirefoxDriver();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Quit();
        }
    }
}
