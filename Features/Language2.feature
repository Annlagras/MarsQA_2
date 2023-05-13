Feature: Seller login and update language

As a seller
I want to login to my profile and add and delete the language option


@sellerLogin
Scenario:Login to seller profile
	Given the seller is on the login page
	When the seller enter the username and password successfully
	Then the seller able to see the seller's profile page


	@LanguageAdd
	Scenario: seller add language successfully
	Given the seller is on the profile page
	When the seller add new language 
	Then the new language should be saved


	@LanguageDelete
	Scenario: Seller delete language successfully
	Given the seller is on the profile page
	When the seller delete the language
	Then the deleted language should be removed

