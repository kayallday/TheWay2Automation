//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;

//namespace Way2AutomateTests.PageObjects
//{
//    class SignUpPage : BasePage
//    {
//        By fullName = By.Id("user_name");
//        By emailAdress = By.Id("user_email");
//        By passWord = By.Id("user_password");
//        By confirmPassword = By.Id("user_password_confirmation");
//        By agreeToTerms = By.Id("user_agreed_to_terms");
//        By signUp = By.ClassName("signup-button");

//        public SignUpPage(IWebDriver driver) : base(driver) { }

//        internal void SelectFullNameInputBox()
//        {
//            By fullNameInputBoxId = By.Id("user_name");
//            WaitUntilClickable(fullNameInputBoxId, WAIT_SECONDS);
//            Click(fullNameInputBoxId);
            
//        } 
//        internal void SelectEmailAddressInputBox()
//        {
//            By emailAddressInputBoxId = By.Id("user_email");
//            WaitUntilClickable(emailAddressInputBoxId, WAIT_SECONDS);
//            Click(emailAddressInputBoxId);
//        }

//        internal void SelectPasswordInputBox()
//        {
//            By passwordInputBoxId = By.Id("user_password");
//            WaitUntilClickable(passwordInputBoxId , WAIT_SECONDS);
//            Click(passwordInputBoxId);
//        }

//        internal void SelectConfirmPasswordInputBox()
//        {
//            By confirmPasswordInputBoxId = By.Id("user_password_confirmation");
//            WaitUntilClickable(confirmPasswordInputBoxId, WAIT_SECONDS);
//            Click(confirmPasswordInputBoxId);
//        }

//        internal void CompleteSignUpForm()
//        {
//            //because there is no way to delete the account you create these will have to be changed every test run
//            Type("Automated Tester", Find(fullName));
//            Type("automatedtestuseremail@gmail.com", Find(emailAdress));
//            Type("AutomateEverything2319", Find(passWord));
//            Type("AutomateEverything2319", Find(confirmPassword));
//        }

//        internal void CheckAgreedToTermsBox()
//        {
//            By checkAgreedToTermsBoxId = By.Id("user_agreed_to_terms");
//            WaitUntilClickable(checkAgreedToTermsBoxId, WAIT_SECONDS);
//            Click(checkAgreedToTermsBoxId);
//        }

//        internal void ClickSignUpButton()
//        {
//            By signUpButtonClass = By.ClassName("signup-button");
//            WaitUntilClickable(signUpButtonClass, WAIT_SECONDS);
//            Click(signUpButtonClass);
//        }

//        internal void ViewCourseDirectory()
//        {
//            By checkSignedInDirectoryClass = By.ClassName("signed-in-directory");
//            WaitUntilDisplayed(checkSignedInDirectoryClass, WAIT_SECONDS);
//        }
//    }
//} 