Feature: OnboardSkill Test Suite

	As a user
	i want to login to mars page
	so that i can add my skill

Scenario: Create a new skill
	Given User logs into the portal
	And user navigates to skill page
	When user creates a new skill
	Then portal should save the skill
