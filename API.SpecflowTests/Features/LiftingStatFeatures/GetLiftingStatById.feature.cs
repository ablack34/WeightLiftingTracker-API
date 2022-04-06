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
    public partial class GetLiftingStatByIdFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "GetLiftingStatById.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/LiftingStatFeatures", "GetLiftingStatById", "\tAs a user of the TrackerAPI\r\n\tI want to be able to get a Lifting Stat\r\n\tSo that " +
                    "I can see my lifting stats", ProgrammingLanguage.CSharp, featureTags);
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "GetLiftingStatById")))
            {
                global::API.SpecflowTests.Features.LiftingStatFeatures.GetLiftingStatByIdFeature.FeatureSetup(null);
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
        
        public virtual void GetALiftingStatByAValidID(string endpointUrl, string responseCode, string exerciseId, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "getPositiveScenario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            argumentsOfScenario.Add("ExerciseId", exerciseId);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a Lifting Stat by a valid ID", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.When(string.Format("I send a \'GET\' request to \'{0}\' endpoint", endpointUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And(string.Format("A \'{0}\' exerciseId are retrieved", exerciseId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get a Lifting Stat by a valid ID: /api/LiftingStats/10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetLiftingStatById")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("getPositiveScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "/api/LiftingStats/10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "/api/LiftingStats/10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "200")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ExerciseId", "1007")]
        public void GetALiftingStatByAValidID_ApiLiftingStats10()
        {
#line 11
this.GetALiftingStatByAValidID("/api/LiftingStats/10", "200", "1007", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get a Lifting Stat by a valid ID: /api/LiftingStats/11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetLiftingStatById")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("getPositiveScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "/api/LiftingStats/11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "/api/LiftingStats/11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "200")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ExerciseId", "1008")]
        public void GetALiftingStatByAValidID_ApiLiftingStats11()
        {
#line 11
this.GetALiftingStatByAValidID("/api/LiftingStats/11", "200", "1008", ((string[])(null)));
#line hidden
        }
        
        public virtual void GetALiftingStatByAInvalidID(string endpointUrl, string responseCode, string responseText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "getNegativeScenario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("EndpointUrl", endpointUrl);
            argumentsOfScenario.Add("ResponseCode", responseCode);
            argumentsOfScenario.Add("ResponseText", responseText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get a Lifting Stat by a invalid ID", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
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
#line 23
 testRunner.When(string.Format("I send a \'GET\' request to \'{0}\' endpoint", endpointUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then(string.Format("A \'{0}\' response is returned", responseCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.And(string.Format("The response should contain \'{0}\'", responseText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get a Lifting Stat by a invalid ID: api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetLiftingStatById")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("getNegativeScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "404")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseText", "Not Found")]
        public void GetALiftingStatByAInvalidID_ApiLiftingStats111()
        {
#line 22
this.GetALiftingStatByAInvalidID("api/LiftingStats/111", "404", "Not Found", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Get a Lifting Stat by a invalid ID: api/LiftingStats/null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "GetLiftingStatById")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("getNegativeScenario")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "api/LiftingStats/null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:EndpointUrl", "api/LiftingStats/null")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseCode", "400")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ResponseText", "One or more validation errors occurred")]
        public void GetALiftingStatByAInvalidID_ApiLiftingStatsNull()
        {
#line 22
this.GetALiftingStatByAInvalidID("api/LiftingStats/null", "400", "One or more validation errors occurred", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
