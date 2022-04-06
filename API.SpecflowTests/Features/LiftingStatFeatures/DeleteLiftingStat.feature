Feature: DeleteExerciseById

	As a user of the TrackerAPI
	I want to be able to delete a lifting stat
	So that I will have an up to date database

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Delete a lifting stat by a valid ID
	When I send a 'DELETE' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl            | ResponseCode |
	| /api/LiftingStats/35   | 204          |
	

@getNegativeScenario
Scenario: Delete a lifting stat by a invalid ID
	When I send a 'DELETE' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl             | ResponseCode | ResponseText							   |
	| api/LiftingStats/111    | 404          | Not Found							   |
	| api/LiftingStats/string | 400          | One or more validation errors occurred  |