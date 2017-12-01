using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Way2AutomateTests.PageObjects
{
    class SignUpPage : BasePage
    {
        public SignUpPage(IWebDriver driver) : base(driver) { }

        internal void SelectFullNameInputBox()
        {
            By fullNameInputBoxId = By.Id("user_name");
            WaitUntilClickable(fullNameInputBoxId, WAIT_SECONDS);
            Click(fullNameInputBoxId);
        } 
        internal void SelectEmailAddressInputBox()
        {
            By emailAddressInputBoxId = By.Id("user_email");
            WaitUntilClickable(emailAddressInputBoxId, WAIT_SECONDS);
            Click(emailAddressInputBoxId);
        } 

        internal void SelectPasswordInputBox()
        {
            By passwordInputBoxId = By.Id("user_password");
            WaitUntilClickable(passwordInputBoxId , WAIT_SECONDS);
            Click(passwordInputBoxId);
        } 

        internal void SelectConfirmPasswordInputBox()
        {
            By confirmPasswordInputBoxId = By.Id("user_password_confirmation");
            WaitUntilClickable(confirmPasswordInputBoxId, WAIT_SECONDS);
            Click(confirmPasswordInputBoxId);
        }

        internal void CheckAgreedToTermsBox()
        {
            By checkAgreedToTermsBoxId = By.Id("user_agreed_to_terms");
            WaitUntilClickable(checkAgreedToTermsBoxId, WAIT_SECONDS);
            Click(checkAgreedToTermsBoxId);
        }

        internal void ClickSignUpButton()
        {
            By signUpButtonClass = By.ClassName("signup-button");
            WaitUntilClickable(signUpButtonClass, WAIT_SECONDS);
            Click(signUpButtonClass);
        }

    }
}
