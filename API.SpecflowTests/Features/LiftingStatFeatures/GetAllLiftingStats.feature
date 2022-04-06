Feature: GetAllLiftingStats

	As a user of the TrackerAPI
	I want to be able to get a list of Lifting Stats
	So that I can see all my lifting stats 

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Get a list of Lifting Stats
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And A list of lifting stats is retrieved

Examples: 
	| EndpointUrl            | ResponseCode |
	| /api/LiftingStats/     | 200          |

@getNegativeScenario
Scenario: Get an Exercise by a invalid ID
	When I send a 'GET' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText |
	| api/LiftingStats/111  | 404          | Not Found    |
	| api/LiftingStats/string | 400          | One or more validation errors occurred  |