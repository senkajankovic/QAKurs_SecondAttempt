Feature: ProductDetailsPage
	In order to purchase products
	As a user
	I want to select and buy from Products Details Page

@Cart
Scenario: User can add product to cart
	Given user opens Dresses section
	And user selects a product
	And increases quantity to 2
	When user submits Add to cart button
	Then product is added to cart
	And quantity of product is 2


