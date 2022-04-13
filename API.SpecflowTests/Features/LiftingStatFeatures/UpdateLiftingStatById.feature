Feature: UpdateLiftingStatById

	As a user of the TrackerAPI
	I want to be able to update a Lifting stat
	So that I can see my ensure an accurate DB record

Background: 
	Given We are running the API with Sample Data

@updatePositiveScenario
Scenario: Update a lifting stat by a valid ID and payload
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 16,
		"date": "2022-04-05",
		"weight": 200,
		"repetitions": 20,
		"exerciseId": 1013
	}
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl            | ResponseCode | 
	| /api/LiftingStats/16   | 202          | 
	

@updateNegativeScenario
Scenario: Update a lifting stat by a invalid ID
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 16,
		"date": "2022-04-05",
		"weight": 50,
		"repetitions": 10,
		"exerciseId": 1013
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl            | ResponseCode | ResponseText   |
	| /api/LiftingStats/1007 | 400          | Bad Request    |


Scenario: Update a lifting stat by a invalid payload
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 16,
		"date": "2022-04-05",
		"weight": "INVALID_DATA",
		"repetitions": 10,
		"exerciseId": 1013
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl            | ResponseCode | ResponseText					   |
	| /api/LiftingStats/1013 | 400          | One or more validation errors    |

Scenario: Update a lifting stat by a invalid route
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 16,
		"date": "2022-04-05",
		"weight": 50,
		"repetitions": 10,
		"exerciseId": 1013
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl              | ResponseCode | ResponseText							   |
	| /api/LiftingStats/string | 400          | One or more validation errors occurred     |