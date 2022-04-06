Feature: GetLiftingStatById

	As a user of the TrackerAPI
	I want to be able to get a Lifting Stat
	So that I can see my lifting stats

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Get a Lifting Stat by a valid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And A '<ExerciseId>' exerciseId are retrieved

Examples: 
	| EndpointUrl            | ResponseCode | ExerciseId   |
	| /api/LiftingStats/10   | 200          | 1007         |
	| /api/LiftingStats/11   | 200          | 1008         |

@getNegativeScenario
Scenario: Get a Lifting Stat by a invalid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl           | ResponseCode | ResponseText |
	| api/LiftingStats/111  | 404          | Not Found    |
	| api/LiftingStats/null | 400          | One or more validation errors occurred  |