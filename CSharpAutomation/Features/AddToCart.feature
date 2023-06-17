Feature: AddToCart

	Me as a user
	I want to add an item to the cart
	So that I can make a purchase in the future

@tag1
Scenario: adding an item to cart

	Given that the user wants to add an item to the cart
	When he chooses the product and clicks on the "Add to cart" button
	And click on the cart icon in the upper right corner of the page
	Then he should be able to view the item successfully added to the cart
