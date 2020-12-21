Feature: Videos on the "Consult & Design" page
	First Video: strats when user pushes the play button and go to FullScreen when user click on the FullScreen Icon.
	Second Video: user click to another slide section and strats the video 

Background: 
	Given user is on the Global English-language home page
	And user accept cookie
	And user follows Consult & Design


Scenario: First video is played in FullScreen
	When user pushes the play buttom
	And click on FullScreen icon
	Then the First video is displayed
	

Scenario: Last video is played
	When user move to another slide section
	And user chooses the Last video
	Then the Last video is displayed