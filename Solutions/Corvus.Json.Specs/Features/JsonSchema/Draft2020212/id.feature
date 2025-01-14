@draft2020-12

Feature: id draft2020-12
    In order to use json-schema
    As a developer
    I want to support id in draft2020-12

Scenario Outline: Invalid use of fragments in location-independent $id
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "$ref": "https://json-schema.org/draft/2020-12/schema"
        }
*/
    Given the input JSON file "id.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/000/tests/000/data | false | Identifier name                                                                  |
        | #/000/tests/001/data | false | Identifier name and no ref                                                       |
        | #/000/tests/002/data | false | Identifier path                                                                  |
        | #/000/tests/003/data | false | Identifier name with absolute URI                                                |
        | #/000/tests/004/data | false | Identifier path with absolute URI                                                |
        | #/000/tests/005/data | false | Identifier name with base URI change in subschema                                |
        | #/000/tests/006/data | false | Identifier path with base URI change in subschema                                |

Scenario Outline: Valid use of empty fragments in location-independent $id
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "$ref": "https://json-schema.org/draft/2020-12/schema"
        }
*/
    Given the input JSON file "id.json"
    And the schema at "#/1/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/001/tests/000/data | true  | Identifier name with absolute URI                                                |
        | #/001/tests/001/data | true  | Identifier name with base URI change in subschema                                |

Scenario Outline: Unnormalized $ids are allowed but discouraged
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "$ref": "https://json-schema.org/draft/2020-12/schema"
        }
*/
    Given the input JSON file "id.json"
    And the schema at "#/2/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/002/tests/000/data | true  | Unnormalized identifier                                                          |
        | #/002/tests/001/data | true  | Unnormalized identifier and no ref                                               |
        | #/002/tests/002/data | true  | Unnormalized identifier with empty fragment                                      |
        | #/002/tests/003/data | true  | Unnormalized identifier with empty fragment and no ref                           |

Scenario Outline: $id inside an enum is not a real identifier
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "$defs": {
                "id_in_enum": {
                    "enum": [
                        {
                          "$id": "https://localhost:1234/draft2020-12/id/my_identifier.json",
                          "type": "null"
                        }
                    ]
                },
                "real_id_in_schema": {
                    "$id": "https://localhost:1234/draft2020-12/id/my_identifier.json",
                    "type": "string"
                },
                "zzz_id_in_const": {
                    "const": {
                        "$id": "https://localhost:1234/draft2020-12/id/my_identifier.json",
                        "type": "null"
                    }
                }
            },
            "anyOf": [
                { "$ref": "#/$defs/id_in_enum" },
                { "$ref": "https://localhost:1234/draft2020-12/id/my_identifier.json" }
            ]
        }
*/
    Given the input JSON file "id.json"
    And the schema at "#/3/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/003/tests/000/data | true  | exact match to enum, and type matches                                            |
        | #/003/tests/001/data | true  | match $ref to $id                                                                |
        | #/003/tests/002/data | false | no match on enum or $ref to $id                                                  |

Scenario Outline: non-schema object containing an $id property
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "$defs": {
                "const_not_id": {
                    "const": {
                        "$id": "not_a_real_id"
                    }
                }
            },
            "if": {
                "const": "skip not_a_real_id"
            },
            "then": true,
            "else" : {
                "$ref": "#/$defs/const_not_id"
            }
        }
*/
    Given the input JSON file "id.json"
    And the schema at "#/4/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/004/tests/000/data | true  | skip traversing definition for a valid result                                    |
        | #/004/tests/001/data | false | const at const_not_id does not match                                             |
