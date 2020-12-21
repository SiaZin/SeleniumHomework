Feature: Instagram page 
	the Social Network icon refers to the correct address
	Intstagram for EPAM Instagram Page
	To see Instagram link you must accept the cookies

Scenario: Instagram Page is correct
	Given I am on the home page
	When I click accept cookies
	Then Link for Instagram Button should be https://www.instagram.com/epamsystems/
	And close the Chrome browser 

	
