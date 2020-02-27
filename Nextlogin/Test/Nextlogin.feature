Feature: Nextlogin
	In order to sign in next
	As a user i am able to sign in
	

@regreesion
Scenario: Verify next sign in
	Given I navigate to Next website
	When I click on My Account
	And I enter user details
	Then I am able to sign in
