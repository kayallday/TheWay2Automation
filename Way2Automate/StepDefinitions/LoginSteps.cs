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

        [Given(@"I am on the SignUp page")]
        public void GivenIAmOnTheSignUpPage()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.VisitSignUpPage();
        }

        [Given(@"I have completed the form with '(.*)' and '(.*)' and '(.*)' and '(.*)'")]
        public void GivenIHaveCompletedTheFormWithAndAndAnd(string p0, string p1, string p2, string p3)
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.CompleteSignUpForm();
        }

        [Given(@"I have checked the I agree to the Terms of Use & Privacy Policy box")]
        public void GivenIHaveCheckedTheIAgreeToTheTermsOfUsePrivacyPolicyBox()
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.CheckAgreedToTermsBox();
        }

        [When(@"I have clicked the Sign Up button")]
        public void WhenIHaveClickedTheSignUpButton()
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.ClickSignUpButton();
        }

        [Then(@"I can see the course directory")]
        public void ThenICanSeeTheCourseDirectory()
        {
            SignUpPage signUpPage = new SignUpPage(Driver);
            signUpPage.ViewCourseDirectory();
        }

    }
}
