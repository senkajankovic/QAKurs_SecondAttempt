Feature: ContactUs
	In order to contact provider
	As a user
	I want to send a message

@mytag
Scenario: UserSendsMessageToProvider
	Given user clicks on Contact Us button
	And enters data into mandatory fields
	And select 'Customer service' from subject heading drop-down
	When user clicks Send button
	Then 'Your message has been successfully sent to our team' message should be displayed
