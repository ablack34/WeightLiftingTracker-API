Feature: CreateALiftingStat

	As a user of the TrackerAPI
	I want to be able to create a lifting stat
	So that I can add new lifting stats for an exercise to track

Background: 
	Given We are running the API with Sample Data

@createPositiveScenario
Scenario: Create a new lifting stat
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 0,
		"date": "2022-04-05",
		"weight": 20,
		"repetitions": 10,
		"exerciseId": 1008
	}
	"""
	Then A '<ResponseCode>' response is returned
	And A response should contain the 'Location' header

#Verify we have actually created the lifting stat by "getting" it
	When I send a 'GET' request to location of last response
	Then A '<GetResponseCode>' response is returned
	And A '<GetExerciseId>' exerciseId are retrieved

#Require the location header so that you can perform a get to confirm that the object was craeted


Examples: 
	| EndpointUrl        | ResponseCode | GetResponseCode | GetExerciseId |
	| /api/LiftingStats/ | 201          | 200             | 1008	      |

@createNegativeScenario
Scenario: Post a lifting stat with invalid payload
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl           | ResponseCode | 
	| api/LiftingStats/     | 400          | 
	 

Scenario: Post a lifting stat to an invalid route
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 0,
		"date": "2022-04-05",
		"weight": 20,
		"repetitions": 10,
		"exerciseId": 1008
	}
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl              | ResponseCode |
	| api/LiftingStats/string  | 405          | 
	| api/LiftingStats/111     | 405          | 


Scenario: Post a lifting stat with a validation errors
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
		"liftingStatId": 0,
		"date": "2022-04-05",
		"weight": "INVALID_DATA",
		"repetitions": "INVALID_DATA",
		"exerciseId": 1008
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl           | ResponseCode | ResponseText							  |
	| api/LiftingStats/     | 400          | One or more validation errors occurred   |
	