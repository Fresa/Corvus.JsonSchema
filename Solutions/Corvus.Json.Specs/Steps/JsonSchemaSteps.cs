﻿// <copyright file="JsonSchemaSteps.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Text.Json;
using Corvus.Json;
using Corvus.Json.CodeGeneration;
using Drivers;

using Microsoft.Extensions.Configuration;

using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Steps;

/// <summary>
/// Steps for the JsonSchema specs generated by Corvus.JsonSchema.SpecGenerator.
/// </summary>
[Binding]
public class JsonSchemaSteps
{
    private const string InputJsonFileName = "InputJsonFileName";
    private const string SchemaPath = "SchemaPath";
    private const string InputData = "InputData";
    private const string InputDataPath = "InputDataPath";
    private const string SchemaType = "SchemaType";
    private const string SchemaInstance = "SchemaInstance";
    private const string SchemaValidationResult = "SchemaValidationResult";
    private readonly FeatureContext featureContext;
    private readonly ScenarioContext scenarioContext;
    private readonly JsonSchemaBuilderDriver driver;
    private readonly IConfiguration configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSchemaSteps"/> class.
    /// </summary>
    /// <param name="featureContext">The current feature context.</param>
    /// <param name="scenarioContext">The current scenario context.</param>
    /// <param name="driver">The json schema builder driver.</param>
    /// <param name="configuration">Configuration settings.</param>
    public JsonSchemaSteps(FeatureContext featureContext, ScenarioContext scenarioContext, JsonSchemaBuilderDriver driver, IConfiguration configuration)
    {
        this.featureContext = featureContext;
        this.scenarioContext = scenarioContext;
        this.driver = driver;
        this.configuration = configuration;
    }

    /// <summary>
    /// Provides the input JSON test file name as a scenario property called <see cref="InputJsonFileName"/>.
    /// </summary>
    /// <param name="inputFileName">The JSON test file name.</param>
    [Given(@"the input JSON file ""(.*)""")]
    public void GivenTheInputJSONFile(string inputFileName)
    {
        this.scenarioContext.Set(inputFileName, InputJsonFileName);
    }

    /// <summary>
    /// Uses the reference fragment to provide the schema JsonElement as a scenario property <see cref="SchemaPath"/>.
    /// </summary>
    /// <param name="referenceFragment">The reference fragment pointing to the relevant schema element in the <see cref="InputJsonFileName"/>.</param>
    [Given(@"the schema at ""(.*)""")]
    public void GivenTheSchemaAt(string referenceFragment)
    {
        this.scenarioContext.Set(referenceFragment, SchemaPath);
    }

    /// <summary>
    /// Uses the reference fragment to provide the data <see cref="JsonElement"/> as a scenario property called <see cref="InputData"/>.
    /// </summary>
    /// <param name="referenceFragment">The reference fragment pointing to the relevant data element in the <see cref="InputJsonFileName"/>.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    [Given(@"the input data at ""(.*)""")]
    public async Task GivenTheInputDataAt(string referenceFragment)
    {
        JsonElement? element = await this.driver.GetElementFromLocalFile(this.scenarioContext.Get<string>(InputJsonFileName), referenceFragment).ConfigureAwait(false);
        Assert.NotNull(
            element,
            $"Failed to load input data at {this.scenarioContext.Get<string>(InputJsonFileName)}, ref {referenceFragment}, jsonSchemaBuilder201909DriverSettings:testBaseDirectory: '{this.configuration["jsonSchemaBuilder201909DriverSettings:testBaseDirectory"]}', jsonSchemaBuilder202012DriverSettings: '{this.configuration["jsonSchemaBuilder202012DriverSettings:testBaseDirectory"]}' CWD: '{Environment.CurrentDirectory}'");
        this.scenarioContext.Set(referenceFragment, InputDataPath);
        this.scenarioContext.Set(element.Value, InputData);
    }

    /// <summary>
    /// Generates the code for the schema in the scenario property <see cref="SchemaPath"/>, compiles it, and loads the assembly. The fully qualified type name is stored in a scenario property called <see cref="SchemaType"/>.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    [Given("I generate a type for the schema")]
    public async Task GivenIGenerateATypeForTheSchema()
    {
        string inputDataPath = this.scenarioContext.Get<string>(InputDataPath);
        string filename = this.scenarioContext.Get<string>(InputJsonFileName);
        string schemaPath = this.scenarioContext.Get<string>(SchemaPath);
        Type type;
        string key = filename + schemaPath;
        if (this.featureContext.ContainsKey(key))
        {
            type = this.featureContext.Get<Type>(key);
        }
        else
        {
            type = await this.driver.GenerateTypeFor(false, int.Parse(inputDataPath.AsSpan().Slice(12, 3)), filename, schemaPath, inputDataPath, Formatting.ToPascalCaseWithReservedWords(this.featureContext.FeatureInfo.Title).ToString(), Formatting.ToPascalCaseWithReservedWords(this.scenarioContext.ScenarioInfo.Title).ToString(), bool.Parse((string)this.scenarioContext.ScenarioInfo.Arguments[1]!)).ConfigureAwait(false);
            this.featureContext.Set(type, key);
        }

        this.scenarioContext.Set(type, SchemaType);
    }

    /// <summary>
    /// Constructs an instance of the type whose name is stored in the scenario property <see cref="SchemaType"/>, using the <see cref="JsonElement"/> stored in the scenario property called <see cref="InputData"/>, and stores it in the scenario property <see cref="SchemaInstance"/>.
    /// </summary>
    [Given("I construct an instance of the schema type from the data")]
    public void GivenIConstructAnInstanceOfTheSchemaTypeFromTheData()
    {
        IJsonValue value = this.driver.CreateInstance(this.scenarioContext.Get<Type>(SchemaType), this.scenarioContext.Get<JsonElement>(InputData));
        this.scenarioContext.Set(value, SchemaInstance);
    }

    /// <summary>
    /// Calls the validation method on the instance in the scenario property <see cref="SchemaInstance"/> and stores the validation result in <see cref="SchemaValidationResult"/>.
    /// </summary>
    [When("I validate the instance")]
    public void WhenIValidateTheInstance()
    {
        IJsonValue jsonValue = this.scenarioContext.Get<IJsonValue>(SchemaInstance);
        ValidationContext validationContext = jsonValue.Validate(ValidationContext.ValidContext);
        this.scenarioContext.Set(validationContext, SchemaValidationResult);
    }

    /// <summary>
    /// Uses the <see cref="ValidationResult"/> stored in the scenario property <see cref="SchemaValidationResult"/> and checks its <see cref="ValidationResult.Valid"/> property.
    /// </summary>
    /// <param name="expectedValidity"><c>True</c> if the result is expected to be valid, otherwiee false.</param>
    [Then("the result will be (.*)")]
    public void ThenTheResultWillBe(bool expectedValidity)
    {
        ValidationContext actual = this.scenarioContext.Get<ValidationContext>(SchemaValidationResult);
        Assert.AreEqual(expectedValidity, actual.IsValid);
    }
}