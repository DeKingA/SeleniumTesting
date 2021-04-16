Feature: CraigslistDemo
	Demonstration for Craigslist Search

@smoke
Scenario: Search Craigslist for Mountain Bike
	Given I launch the application
	And I enter 'Mountain Bike' into the searchbox
	And I click 'has image'
	And I enter the  price
		| MinPrice | MaxPrice |
		| 250      | 500      |
	And I scroll down
	And I click the 'update search' button
	And I click the top post
	Then I should get the price and ad information
	And Save data to database
	And Log data to database
	Then I should close the browser