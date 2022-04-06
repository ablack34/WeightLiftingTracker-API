Feature: GetExerciseById

	As a user of the TrackerAPI
	I want to be able to get an Exercise
	So that I can see my lifting stats

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Get an Exercise by a valid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And A '<ExerciseName>' exercise details are retrieved

Examples: 
	| EndpointUrl         | ResponseCode | ExerciseName |
	| /api/Exercises/1009 | 200          | KB Swing     |
	| /api/Exercises/1008 | 200          | Lunge        |

@getNegativeScenario
Scenario: Get an Exercise by a invalid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText |
	| api/Exercises/111  | 404          | Not Found    |
	| api/Exercises/null | 400          | One or more validation errors occurred  |