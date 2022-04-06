Feature: ProfileDetails

As a seller I should be able to add my profile details so that people seeking for some skills can look into my details.


Scenario: Adding a language to the profile page
	Given I logged into the Turnup portal successfully
	When I adding '<Language>', and level in the profile page and save it
	Then then '<Language>' and level should be saved successfully
	Examples: 
	| Language |    
	| malayalam  |  
	

	Scenario: Editing a language in the profile page
	Given I logged into the Turnup portal successfully
	When I editing '<Language>' and level and save it
	Then the edited '<Language>' and level should be saved successfully
	Examples: 
	| Language |  
	| Hindi  |    

	Scenario: Deleting a language in the profile page
	Given I logged into the Turnup portal successfully	
	When I  Removing language and save it
	Then the language should be removed successfully

	
	Scenario: Adding skills to the profile page
	Given I logged into the Turnup portal successfully
	When I added skills and save it
	Then the skills should be saved successfully

Scenario: Editing skills in the profile page
	Given I logged into the Turnup portal successfully
	When I edited skills and save it
	Then the edited skills should be saved successfully


Scenario: Deleting a skills in the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing language and save it
	Then the skills should be removed successfully

Scenario: Adding Education to the profile page
	Given I logged into the Turnup portal successfully
	When I added Education and save it
	Then the Education should be saved successfully

Scenario: Editing Education in the profile page
	Given I logged into the Turnup portal successfully
	When I edited Education and save it
	Then the Edited education should be saved successfully


Scenario: Deleting Education from the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing Education and save it
	Then the Education should be removed successfully

	Scenario: Adding Certifications to the profile page
	Given I logged into the Turnup portal successfully
	When I added certifications and save it
	Then the certifications should be saved successfully

	Scenario: Editing Certifications in the profile page
	Given I logged into the Turnup portal successfully
	When I edited certifications and save it
	Then the edited certifications should be saved successfully


Scenario: Deleting Certifications from the profile page
	Given I logged into the Turnup portal successfully
	When I  Removing certifications and save it
	Then the Certifications should be removed successfully

