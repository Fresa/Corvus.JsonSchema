@draft6

Feature: email draft6
    In order to use json-schema
    As a developer
    I want to support email in draft6

Scenario Outline: validation of e-mail addresses
/* Schema: 
{ "format": "email" }
*/
    Given the input JSON file "optional/format/email.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/000/tests/000/data | true  | all string formats ignore integers                                               |
        | #/000/tests/001/data | true  | all string formats ignore floats                                                 |
        | #/000/tests/002/data | true  | all string formats ignore objects                                                |
        | #/000/tests/003/data | true  | all string formats ignore arrays                                                 |
        | #/000/tests/004/data | true  | all string formats ignore booleans                                               |
        | #/000/tests/005/data | true  | all string formats ignore nulls                                                  |
        | #/000/tests/006/data | true  | a valid e-mail address                                                           |
        | #/000/tests/007/data | false | an invalid e-mail address                                                        |
        | #/000/tests/008/data | true  | tilde in local part is valid                                                     |
        | #/000/tests/009/data | true  | tilde before local part is valid                                                 |
        | #/000/tests/010/data | true  | tilde after local part is valid                                                  |
        | #/000/tests/011/data | false | dot before local part is not valid                                               |
        | #/000/tests/012/data | false | dot after local part is not valid                                                |
        | #/000/tests/013/data | true  | two separated dots inside local part are valid                                   |
        | #/000/tests/014/data | false | two subsequent dots inside local part are not valid                              |
