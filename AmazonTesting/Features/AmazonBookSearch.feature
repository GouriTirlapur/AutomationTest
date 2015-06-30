Feature: AmazonBookSearch
	As an enduser 
	I should be able to serach a book
	And  add the book to the shopping cart.

@mytag
Scenario Outline: Search Book and to shopping cart.
	Given a user has searched a <book>
	When he clicks add to cart button
	Then book should be added to the shopping cart.
	Examples: 
	| book          |
	| The Alchemist |
	| The Habit     |
