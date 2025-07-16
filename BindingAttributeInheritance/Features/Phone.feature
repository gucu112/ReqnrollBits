@Phone
Feature: Phone

Simple phone which calls last number

Scenario: Call the last number
	Given the phone number 000000000
	And the second phoner number 123456789
	When the phone call is made
	Then the phone call happened
