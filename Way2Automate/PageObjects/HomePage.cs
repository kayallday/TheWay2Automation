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
        public HomePage(IWebDriver driver) : base(driver) { }

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

        internal void ClickMemberLoginButton()
        {
            By MemberLoginLink = By.CssSelector("a[href='https://sso.teachable.com/secure/673/users/sign_in?reset_purchase_session=1']");
            WaitUntilClickable(MemberLoginLink, WAIT_SECONDS);
            Click(MemberLoginLink);
        }

        internal void VisitLoginPage()
        {
            string loginPageURL = "https://sso.teachable.com/secure/673/users/sign_in?clean_login=true&reset_purchase_session=1";
            Visit(loginPageURL);
            By loginFormId = By.Id("new_user");
            WaitUntilDisplayed(loginFormId, WAIT_SECONDS);
        }
        internal void VisitSignUpPage()
        {
            string signUpPageURL = "https://sso.teachable.com/secure/673/users/sign_up?flow_school_id=673";
            Visit(signUpPageURL );
            By signUpFormId = By.Id("new_user");
            WaitUntilDisplayed(signUpFormId, WAIT_SECONDS);
        }
    }
}
