Feature: SearchOption
	In order to find wanted products
	As a user
	I want to be to search key words

@Search
Scenario: Search products by keyword
	Given user enters a word 'Dress' into serach box
	When click on button search
	Then list of results including 'Dress' displays
