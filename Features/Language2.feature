Feature: Seller adding profile details
As a seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.

Scenario: Seller add the profile details
	Given seller logged into localhost successfully
	When seller navigate to Profile Page
	And seller added the profile details
	Then The profile details added successfully

Scenario Outline: Seller add the language details
Given seller logged into localhost successfully
When seller navigate to Profile Page
And seller updated '<language>' details
Then The details added successfully '<language>'


Scenario Outline: Seller delete the language details
Given seller logged into localhost successfully
When the seller navigate to profile page
And seller select a <'language' 
And seller delete the selected '<language>' details
Then the details removed successfully '<language>'

	
Examples: 
| language | level    |
| English  | Expert   |
| Hindi    | Basic    |