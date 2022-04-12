﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace API.SpecflowTests.Features.LiftingStatFeatures
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CreateALiftingStatFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "CreateLiftingStat.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/LiftingStatFeatures", "CreateALiftingStat", "\tAs a user of the TrackerAPI\r\n\tI want to be able to create a lifting stat\r\n\tSo th" +
                    "at I can add new lifting stats for an exercise to track", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "CreateALiftingStat")))
            {
                global::API.SpecflowTests.Features.LiftingStatFeatures.CreateALiftingStatFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
#line 8
 testRunner.Given("We are running the API with Sample Data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void CreateANewLiftingStat(string endpointUrl, string responseCode, string getResponseCode, string getExerciseId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "createPositiveScenario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            argumentsOfScenario.Add("GetResponseCode", getResponseCode);
            argumentsOfScenario.Add("GetExerciseId", getExerciseId);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new lifting stat", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 12
 testRunner.When(string.Format("I send a \'POST\' request to \'{0}\' endpoint with payload", endpointUrl), "{\r\n\t\"liftingStatId\": 0,\r\n\t\"date\": \"2022-04-05\",\r\n\t\"weight\": 20,\r\n\t\"repetitions\": " +
                        "10,\r\n\t\"exerciseId\": 1008\r\n}", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("A response should contain the \'Location\' header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("I send a \'GET\' request to location of last response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then(string.Format("A \'{0}\' response is returned", getResponseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.And(string.Format("A \'{0}\' exerciseId are retrieved", getExerciseId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Create a new lifting stat: /api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CreateALiftingStat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("createPositiveScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "/api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "/api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "201")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GetResponseCode", "200")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:GetExerciseId", "1008")]
        public void CreateANewLiftingStat_ApiLiftingStats()
        {
#line 11
this.CreateANewLiftingStat("/api/LiftingStats/", "201", "200", "1008", ((string[])(null)));
#line hidden
        }
        
        public virtual void PostALiftingStatWithInvalidPayload(string endpointUrl, string responseCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "createNegativeScenario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post a lifting stat with invalid payload", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 39
 testRunner.When(string.Format("I send a \'POST\' request to \'{0}\' endpoint with payload", endpointUrl), "", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post a lifting stat with invalid payload: api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CreateALiftingStat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("createNegativeScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "400")]
        public void PostALiftingStatWithInvalidPayload_ApiLiftingStats()
        {
#line 38
this.PostALiftingStatWithInvalidPayload("api/LiftingStats/", "400", ((string[])(null)));
#line hidden
        }
        
        public virtual void PostALiftingStatToAnInvalidRoute(string endpointUrl, string responseCode, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post a lifting stat to an invalid route", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 51
 testRunner.When(string.Format("I send a \'POST\' request to \'{0}\' endpoint with payload", endpointUrl), "{\r\n\t\"liftingStatId\": 0,\r\n\t\"date\": \"2022-04-05\",\r\n\t\"weight\": 20,\r\n\t\"repetitions\": " +
                        "10,\r\n\t\"exerciseId\": 1008\r\n}", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post a lifting stat to an invalid route: api/LiftingStats/string")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CreateALiftingStat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/string")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/string")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "405")]
        public void PostALiftingStatToAnInvalidRoute_ApiLiftingStatsString()
        {
#line 50
this.PostALiftingStatToAnInvalidRoute("api/LiftingStats/string", "405", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post a lifting stat to an invalid route: api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CreateALiftingStat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "405")]
        public void PostALiftingStatToAnInvalidRoute_ApiLiftingStats111()
        {
#line 50
this.PostALiftingStatToAnInvalidRoute("api/LiftingStats/111", "405", ((string[])(null)));
#line hidden
        }
        
        public virtual void PostALiftingStatWithAValidationErrors(string endpointUrl, string responseCode, string responseText, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            argumentsOfScenario.Add("ResponseText", responseText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post a lifting stat with a validation errors", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 69
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
this.FeatureBackground();
#line hidden
#line 70
 testRunner.When(string.Format("I send a \'POST\' request to \'{0}\' endpoint with payload", endpointUrl), "{\r\n\t\"liftingStatId\": 0,\r\n\t\"date\": \"2022-04-05\",\r\n\t\"weight\": \"INVALID_DATA\",\r\n\t\"re" +
                        "petitions\": \"INVALID_DATA\",\r\n\t\"exerciseId\": 1008\r\n}", ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.And(string.Format("The response should contain \'{0}\'", responseText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post a lifting stat with a validation errors: api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "CreateALiftingStat")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "400")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseText", "One or more validation errors occurred")]
        public void PostALiftingStatWithAValidationErrors_ApiLiftingStats()
        {
#line 69
this.PostALiftingStatWithAValidationErrors("api/LiftingStats/", "400", "One or more validation errors occurred", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion