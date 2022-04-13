Feature: UpdateExerciseById

	As a user of the TrackerAPI
	I want to be able to update an exercise
	So that I can see my ensure an accurate DB record 

Background: 
	Given We are running the API with Sample Data

@updatePositiveScenario
Scenario: Update an Exercise by a valid ID and payload
	When I send a 'PUT' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 1020,
	  "name": "Test Exercise",
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
#	And A response should contain the 'Location' header
#
#	When I send a 'GET' request to location of last response
#	Then A '<GetResponseCode>' response is returned
#	And A '[int]' exerciseId are retrieved
#	
#	#How do I get the exerciseId of the newly created exercise so that I can update it
#	#exerciseId is autoGen 
#	#Internal Server Error if i try to set the exerciseId
#
#	When I send a 'PUT' request to location of last response
#	Then A 'Test Exercise' exercise details are retrieved
#	
#	Then A '<PutResponseCode>' response is returned

Examples: 
	| EndpointUrl         | ResponseCode |
	| /api/Exercises/1020 | 202          | 
	

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