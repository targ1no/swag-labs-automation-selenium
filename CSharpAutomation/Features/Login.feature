Feature: Login

	Me as a user
	I want to login to the system

Scenario: Success Login

	Given that user wants to login to the system
	When he enter the valid credentials
	Then it must be inserted in the HomePage of the system, logging in successfully
