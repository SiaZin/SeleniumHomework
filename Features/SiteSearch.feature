@all
Feature: Site Search 
 User uses english version of the site. The search bar is filled with some words
 Search is successeful if user entered correct data
 Site should  display error message if data is incorrect

 @correct
 Scenario Outline: Successful search
	Given I am on the Global English-language home page
	When I use the search bar 
	And I search for <keyword>
	And I press find button
	Then I should see <num> as the number of the results for my request
	And close the browser 

	Examples: 
	| keyword    | num |
	| DevOps     | 124 |
	| cloud      | 344 |

 @fail
 Scenario: Unsuccessful search
	Given I am on the Global English-language home page
	When I use the search bar 
	And I enter Russian words
	And I press find button 
	Then Error message is displayed
	And close the browser 