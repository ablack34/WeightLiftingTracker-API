Feature: GetAllExercises

	As a user of the TrackerAPI
	I want to be able to get a list of Exercises
	So that I can see what exercises there are 

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Get a list of Exercises
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And A list of exercises is retrieved

Examples: 
	| EndpointUrl         | ResponseCode |
	| /api/Exercises/     | 200          |

@getNegativeScenario
Scenario: Get an Exercise by a invalid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText |
	| api/Exercises/111  | 404          | Not Found    |
	| api/Exercises/null | 400          | One or more validation errors occurred  |