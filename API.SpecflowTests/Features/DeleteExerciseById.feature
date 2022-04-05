Feature: DeleteExerciseById

	As a user of the TrackerAPI
	I want to be able to delete an Exercise
	So that I will have an up to date database

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Delete an Exercise by a valid ID
	When I send a 'DELETE' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl         | ResponseCode |
	| /api/Exercises/1011 | 204          |
	| /api/Exercises/1012 | 204          |

@getNegativeScenario
Scenario: Delete an Exercise by a invalid ID
	When I send a 'DELETE' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText |
	| api/Exercises/111  | 404          | Not Found    |
	| api/Exercises/null | 400          | One or more validation errors occurred  |