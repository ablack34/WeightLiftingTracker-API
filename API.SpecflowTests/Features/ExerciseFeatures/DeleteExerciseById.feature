Feature: DeleteExerciseById

	As a user of the TrackerAPI
	I want to be able to delete an Exercise
	So that I will have an up to date database

Background: 
	Given We are running the API with Sample Data

@getPositiveScenario
Scenario: Delete an Exercise by a valid ID
	When I send a 'POST' request to '<EndpointUrl>' endpoint with payload
	"""
	{
	  "exerciseId": 0,
	  "name": "Test",
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

	When I send a 'GET' request to location of last response
	Then A '<GetResponseCode>' response is returned
	And A '<GetExerciseName>' exercise details are retrieved

	When I send a 'DELETE' request to location of last response
	Then A '204' response is returned

	When I send a 'GET' request to location of last response
	Then A '404' response is returned

Examples:
	| EndpointUrl         | ResponseCode | GetResponseCode | GetExerciseName |
	| /api/Exercises/	  | 201          | 200             | Test			 |

@getNegativeScenario
Scenario: Delete an Exercise by a invalid ID
	When I send a 'DELETE' request to '<EndpointUrl>' endpoint
	Then A '<ResponseCode>' response is returned
	And The response should contain '<ResponseText>'

Examples: 
	| EndpointUrl        | ResponseCode | ResponseText |
	| api/Exercises/111  | 404          | Not Found    |
	| api/Exercises/null | 400          | One or more validation errors occurred  |