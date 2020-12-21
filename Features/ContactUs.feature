@all
Feature: Contact Us
	Submit the inquiry
	Success when all needed data is filled and check box marked
	Failed when check box is not marked

Background: 
	Given User is on the Global English-language home page
	And User follows Contact Us

@fail
Scenario: Unsuccessful submit
	#Given user is on the registration page
	When user enters the details 
	| Key                         | Value               |
	| Email                       | test.user@gmail.com |
	| First Name                  | Test                |
	| Last Name                   | User                |
	| Phone                       | +380955230087       |
	| Location                    | Ukraine             |
#	| How did you hear about Epam | Search              |
	And user clicks Submit
	Then user returns back on registration page

@correct
Scenario: Successful submit
	#Given user is on the registration page 
	When user enters the details 
	| Key                         | Value               |
	| Email                       | test.user@gmail.com |
	| First Name                  | Test                |
	| Last Name                   | User                |
	| Phone                       | +380955230087       |
	| Location                    | Ukraine             |
	#| How did you hear about Epam | Search              |
	And user clicks check box for processing personal information
	And user clicks Submit
	Then user should see successful notification