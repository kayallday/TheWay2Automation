Feature: Login
	As an ordinary user 
	I want to be able to create an account 
	So that I can login 

#@Login
#Scenario Outline: SignUp
#	Given I am on the SignUp page  
#	And I have completed the form with <fullname> and <email> and <password> and <passwordConfirmation>
#	And I have checked the I agree to the Terms of Use & Privacy Policy box
#	When I have clicked the Sign Up button
#	Then I can see the course directory
#		Examples:
#		| fullname         | email                            | password               | passwordConfirmation   |
#		| Automated Tester | automatedtestuseremail@gmail.com | AutomateEverything2319 | AutomateEverything2319 | 
	
@Login
Scenario Outline: Login 
	Given I am on the Login page
	And I have completed the form with '<email>' and '<password>'
	When I have clicked the LogIn button
	Then I can see the course directory
	Examples:
	| email | password | 
	| automatedtestuseremail@gmail.com | AutomateEverything2319 |
	

#@Login
#Scenario: Login with Credentials
#	Given I am on the HomePage 
#	Given I have clicked the Member Login Button  
#	Then A new window is opened display the login page


