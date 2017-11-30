Feature: Login
	As an ordinary user 
	I want to be able to create an account 
	So that I can login 


@Login
Scenario: View the Login Window
	Given I am on the HomePage 
	Given I have clicked the Member Login Button  
	Then A new window is opened display the login page

@Login
Scenario Outline: SignUp
	Given I have clicked the Create an Account link
	Given I am on the Sign Up page  
	And I have completed the form with '<fullname>' and '<email>' and '<password>' and '<passwordCofirmation>'

		Examples:
		| fullname         | email                            | password               | passwordConfirmation   |
		| Automated Tester | automatedtestuseremail@gmail.com | AutomateEverything2319 | AutomateEverything2319 | 

	And I have checked the I agree to the Terms of Use & Privacy Policy box
	When I have clicked the Sign Up button
	Then I will be logged in as '<fullname>'

		
#@Login
#Scenario Outline: SignUp with invalid details 
#	Given I have clicked the Create an Account link
#	Given I am on the Sign Up page  
#	And I have completed the form with '<fullname>' and '<email>' and '<password>' and '<passwordCofirmation>'
#	| fullname | email | password | passwordConfirmation |  
#	| Automated Tester | automatedtestuseremailgmail.com | Automate | AutomateEverything2319 |  
#	And I have checked the I agree to the Terms of Use & Privacy Policy box
#	When I have clicked the Sign Up button
#	Then I will get an error message

	

#@Login
#Scenario: Login with Credentials
#	Given I am on the HomePage 
#	Given I have clicked the Member Login Button  
#	Then A new window is opened display the login page


