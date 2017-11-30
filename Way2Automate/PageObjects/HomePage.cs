using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Way2AutomateTests.PageObjects
{
    class HomePage : BasePage
    {
        protected HomePage(IWebDriver driver) : base(driver) { }

        internal void VisitBuySeleniumNowPage()
        {
            string visitBuySeleniumNowURL = "";
            Visit(visitBuySeleniumNowURL);
            By BuyNowBreadCrumb = By.ClassName("section-breadcrumb");
            WaitUntilDisplayed(BuyNowBreadCrumb, WAIT_SECONDS);
        }

        internal void VisitHomepage()
        {
            Visit("");
            By Slider = By.Id("slider-pro.main-slider.sp-horizontal");
            WaitUntilDisplayed(Slider, WAIT_SECONDS);
        }

    }
}
