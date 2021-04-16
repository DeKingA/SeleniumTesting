Feature: Craigslist
Specflow, Gherkin and Selenium demonstration using Craigslist, Bellingham.

@smoke
Scenario: Get top result for Mountain Bike Search
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120