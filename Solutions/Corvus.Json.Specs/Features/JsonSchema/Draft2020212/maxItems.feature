@draft2020-12

Feature: maxItems draft2020-12
    In order to use json-schema
    As a developer
    I want to support maxItems in draft2020-12

Scenario Outline: maxItems validation
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "maxItems": 2
        }
*/
    Given the input JSON file "maxItems.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/000/tests/000/data | true  | shorter is valid                                                                 |
        | #/000/tests/001/data | true  | exact length is valid                                                            |
        | #/000/tests/002/data | false | too long is invalid                                                              |
        | #/000/tests/003/data | true  | ignores non-arrays                                                               |

Scenario Outline: maxItems validation with a decimal
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "maxItems": 2.0
        }
*/
    Given the input JSON file "maxItems.json"
    And the schema at "#/1/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/001/tests/000/data | true  | shorter is valid                                                                 |
        | #/001/tests/001/data | false | too long is invalid                                                              |
