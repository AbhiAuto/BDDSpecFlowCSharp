@mytagFeature
Feature: Finding the links related to BDD cucumber 

@mytagScenarioPos
Scenario: Search BDD cucumber in google and find the links related
	Given I have google web application
	And I enter "BDD cucumber" in the search box
	When I click on google search button 
	Then I should see links with details of BDD cucumber should be displayed


