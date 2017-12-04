using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Way2AutomateTests.PageObjects
{
    class LoginPage : BasePage
    {
        By emailAddress = By.Id("user_email");
        By passWord = By.Id("user_password");

        public LoginPage(IWebDriver driver) : base(driver) { }

        internal void CompleteLoginForm()
        {
            Type("automatedtestuseremail@gmail.com", Find(emailAddress));
            Type("AutomateEverything2319", Find(passWord));
        }

        internal void ClickLogInButton()
        {
            By clickLogInButtonId = By.ClassName("login-button");
            WaitUntilClickable(clickLogInButtonId, WAIT_SECONDS);
            Click(clickLogInButtonId);
        }

        internal void ViewCourseDirectory()
        {
            By checkSignedInDirectoryClass = By.ClassName("signed-in-directory");
            WaitUntilDisplayed(checkSignedInDirectoryClass, WAIT_SECONDS);
        }
    }
}
