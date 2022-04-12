using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using TechTalk.SpecFlow;
using TrackerAPI.Data;
using API.SpecflowTests.Contexts;
using System.Net;
using TrackerAPI.Models;
using API.SpecflowTests.Helpers;
using System.Text;

namespace API.SpecflowTests.StepDefinitions
{
    [Binding]
    public class GetExerciseByIdStepDefinitions
    {
        
        private TestExerciseContext _context;

        public GetExerciseByIdStepDefinitions(TestExerciseContext context)
        {
            _context = context;
        }

        [BeforeScenario("Update an Exercise by a valid ID and payload")]
        [When(@"I Insert Mock Data to '([^']*)'")]
        public async Task WhenIInsertMockData(HttpMethod method, Uri uri, string payload)
        {
            GivenWeAreRunningTheAPIWithSampleData();
            await WhenISendARequestToEndpointWithPayload(method, uri, payload);
            ThenAResponseIsReturned(HttpStatusCode.OK);
        }


        [Given(@"We are running the API with Sample Data")]
        public void GivenWeAreRunningTheAPIWithSampleData()
        {
            _context!.HttpClient = new WebApplicationFactory<Program>().CreateClient();
        }

        [When(@"I send a '([^']*)' request to '([^']*)' endpoint")]
        public async Task WhenISendARequestToEndpoint(HttpMethod method, Uri uri)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, uri);

            _context!.LastHttpResponseMessage = await _context!.HttpClient!.SendAsync(request);
        }

        [When(@"I send a '([^']*)' request to '([^']*)' endpoint with payload")]
        public async Task WhenISendARequestToEndpointWithPayload(HttpMethod method, Uri uri, string payload)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, uri)
            {
                Content = new StringContent(payload, encoding: Encoding.UTF8, mediaType: "application/json")
            };

            _context!.LastHttpResponseMessage = await _context!.HttpClient!.SendAsync(request);
        }

        [When(@"I send a '([^']*)' request to location of last response")]
        public async Task WhenISendARequestToLocationOfLastResponse(HttpMethod method)
        {
            await WhenISendARequestToEndpoint(method, new Uri(_context!.LastHttpResponseMessageLocationHeaderValue!));
        }

        [When(@"I send a '([^']*)' request to location of last response with payload")]
        public async Task WhenISendARequestToLocationOfLastResponseWithPayload(HttpMethod method, string payload)
        {
            var uri = new Uri(_context!.LastHttpResponseMessageLocationHeaderValue!);

            HttpRequestMessage request = new HttpRequestMessage(method, uri)
            {
                Content = new StringContent(payload, encoding: Encoding.UTF8, mediaType: "application/json")
            };

            _context!.LastHttpResponseMessage = await _context!.HttpClient!.SendAsync(request);
        }


        [Then(@"A '([^']*)' response is returned")]
        public void ThenAResponseIsReturned(HttpStatusCode expectedhttpStatusCode)
        {
            _context!.LastHttpResponseMessage!.StatusCode.Should().Be(expectedhttpStatusCode);
        }

        [Then(@"A '([^']*)' exercise details are retrieved")]
        public async Task ThenAExerciseDetailsAreRetrieved(string expectedExerciseName)
        {
            Exercise exerciseResult = await _context!.LastHttpResponseMessage!.GetBodyAs<Exercise>();

            exerciseResult.Should().NotBeNull();
            exerciseResult.Name.Should().Be(expectedExerciseName);
        }

        [Then(@"A '([^']*)' exerciseId are retrieved")]
        public async Task ThenAExerciseIdAreRetrieved(int expectedExerciseId)
        {
            LiftingStat liftingStatResult = await _context!.LastHttpResponseMessage!.GetBodyAs<LiftingStat>();

            liftingStatResult.ExerciseId.Should().Be(expectedExerciseId);
        }


        [Then(@"A list of lifting stats is retrieved")]
        public async Task ThenAListOfLiftingStatsIsRetrieved()
        {
            List<LiftingStat> listOfExercises = await _context!.LastHttpResponseMessage!.GetBodyAs<List<LiftingStat>>();

            listOfExercises.Should().NotBeNull();
        }


        [Then(@"The response should contain '([^']*)'")]
        public async Task ThenTheResponseShouldContain(string expectedResponseText)
        {
            string responseBody = await _context!.LastHttpResponseMessage!.GetBodyAsString();

            responseBody.Should().Contain(expectedResponseText);
        }

        [Then(@"A list of exercises is retrieved")]
        public async Task ThenAListOfExercisesIsRetrieved()
        {
            List<Exercise> listOfExercises = await _context!.LastHttpResponseMessage!.GetBodyAs<List<Exercise>>();

            listOfExercises.Should().NotBeNull();
        }

        [Then(@"A response should contain the '([^']*)' header")]
        public void ThenAResponseShouldContainTheHeader(string targetHeaderName)
        {
            var headers = _context!.LastHttpResponseMessage!.Headers.ToDictionary(x => x.Key, x => x.Value.FirstOrDefault());

            var targetHeader = headers.FirstOrDefault(x => x.Key.Equals(targetHeaderName)).Value;

            targetHeader.Should().NotBeNull();

            _context!.LastHttpResponseMessageLocationHeaderValue = targetHeader;

        }



    }
}
