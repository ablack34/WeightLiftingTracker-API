Feature: CreateAnExercise

	As a user of the TrackerAPI
	I want to be able to create an Exercise
	So that I can add new exercises to track

Background: 
	Given We are running the API with Sample Data

@createPositiveScenario
Scenario: Create a new exercise
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 0,
	  "name": "Push Press",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": 100,
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned
	And A response should contain the 'Location' header

#Verify we have actually created th exercise by "getting" it
	When I send a 'GET' request to location of last response
	Then A '<GetResponseCode>' response is returned
	And A '<GetExerciseName>' exercise details are retrieved

#Require the location header so that you can perform a get to confirm that the object was craeted


Examples: 
	| EndpointUrl     | ResponseCode | GetResponseCode | GetExerciseName |
	| /api/Exercises/ | 201          | 200             | Push Press      |

@createNegativeScenario
Scenario: Post an Exercise with invalid payload
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl        | ResponseCode | 
	| api/Exercises/     | 400          | 
	 

Scenario: Post an Exercise to an invalid route
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 0,
	  "name": "Clean",
	  "stats": [
		{
		  "liftingStatId": 0,
		  "date": "2022-04-05",
		  "weight": 100,
		  "repetitions": 3,
		  "exerciseId": 0
		}
	  ]
	}
	"""
	Then A '<ResponseCode>' response is returned

Examples: 
	| EndpointUrl           | ResponseCode |
	| api/Exercises/string  | 405          | 
	| api/Exercises/111     | 405          | 


Scenario: Post an Exercise with a validation errors
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 0,
	  "name": "Clean",
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
	| EndpointUrl        | ResponseCode | ResponseText							  |
	| api/Exercises/     | 400          | One or more validation errors occurred  |
	