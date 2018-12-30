Feature: Footer	
	In order to use footer links
	As a user
	I want to use My Account links 

@Footer
Scenario Outline: My Account links from footer open correct pages
	Given user opens sign in page
	And enters correct credentials
	And user submits the login form
	When user clicks on '<My Account link>'
	Then correct page '<page>' opens
Examples: 
	| My Account link                | page       |
	| My orders                      | history    |
	| My credit slips                | order-slip |
	| My addresses                   | addresses  |
	| Manage my personal information |	identity	|
	| Sign out         |	authentication	|
