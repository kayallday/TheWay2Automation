using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Way2AutomateTests.PageObjects;

namespace Way2AutomateTests.StepDefinitions
{
    [Binding]
    class LoginSteps : BaseSteps
    {
        [BeforeScenario("Login")]
        public void BeforeLoginScenario()
        {
            LoadConfigValues();
            CheckBrowser();
        }

        [AfterScenario("Login")]
        public void AfterLoginScenario()
        {
            Driver.Quit();
        }

        [Given(@"I am on the HomePage")]
        public void GivenIAmOnTheHomePage()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.VisitHomepage();
        }

        [Given(@"I have clicked the Member Login Button")]
        public void GivenIHaveClickedTheMemberLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"A new window is opened display the login page")]
        public void ThenANewWindowIsOpenedDisplayTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have clicked the Create an Account link")]
        public void GivenIHaveClickedTheCreateAnAccountLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Sign Up page")]
        public void GivenIAmOnTheSignUpPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have completed the form with '(.*)' and '(.*)' and '(.*)' and '(.*)'")]
        public void GivenIHaveCompletedTheFormWithAndAndAnd(string p0, string p1, string p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have checked the I agree to the Terms of Use & Privacy Policy box")]
        public void GivenIHaveCheckedTheIAgreeToTheTermsOfUsePrivacyPolicyBox()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I have clicked the Sign Up button")]
        public void WhenIHaveClickedTheSignUpButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I will be logged in as '(.*)'")]
        public void ThenIWillBeLoggedInAs(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
