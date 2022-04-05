Feature: UpdateExerciseById

	As a user of the TrackerAPI
	I want to be able to get an Exercise
	So that I can see my lifting stats

Background: 
	Given We are running the API with Sample Data

@updatePositiveScenario
Scenario: Update an Exercise by a valid ID and payload
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 1007,
	  "name": "Box jump",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": 50,
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl         | ResponseCode | 
	| /api/Exercises/1007 | 202          | 
	

@updateNegativeScenario
Scenario: Update an Exercise by a invalid ID
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 111,
	  "name": "Push-up",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": 50,
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl         | ResponseCode | ResponseText   |
	| /api/Exercises/1007 | 400          | Bad Request    |


Scenario: Update an Exercise by a invalid payload
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 1007,
	  "name": "Push-up",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": "INVALID_DATA",
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText					   |
	| /api/Exercises/1007 | 400          | One or more validation errors    |

Scenario: Update an Exercise by a invalid route
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 1007,
	  "name": "Push-up",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": 50,
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText	|
	| /api/Exercises/111 | 400          | Bad Request   |