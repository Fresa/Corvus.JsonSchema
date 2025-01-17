@draft2020-12

Feature: uri draft2020-12
    In order to use json-schema
    As a developer
    I want to support uri in draft2020-12

Scenario Outline: validation of URIs
/* Schema: 
{
            "$schema": "https://json-schema.org/draft/2020-12/schema",
            "format": "uri"
        }
*/
    Given the input JSON file "optional/format/uri.json"
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
        | #/000/tests/006/data | true  | a valid URL with anchor tag                                                      |
        | #/000/tests/007/data | true  | a valid URL with anchor tag and parentheses                                      |
        | #/000/tests/008/data | true  | a valid URL with URL-encoded stuff                                               |
        | #/000/tests/009/data | true  | a valid puny-coded URL                                                           |
        | #/000/tests/010/data | true  | a valid URL with many special characters                                         |
        | #/000/tests/011/data | true  | a valid URL based on IPv4                                                        |
        | #/000/tests/012/data | true  | a valid URL with ftp scheme                                                      |
        | #/000/tests/013/data | true  | a valid URL for a simple text file                                               |
        | #/000/tests/014/data | true  | a valid URL                                                                      |
        | #/000/tests/015/data | true  | a valid mailto URI                                                               |
        | #/000/tests/016/data | true  | a valid newsgroup URI                                                            |
        | #/000/tests/017/data | true  | a valid tel URI                                                                  |
        | #/000/tests/018/data | true  | a valid URN                                                                      |
        | #/000/tests/019/data | false | an invalid protocol-relative URI Reference                                       |
        | #/000/tests/020/data | false | an invalid relative URI Reference                                                |
        | #/000/tests/021/data | false | an invalid URI                                                                   |
        | #/000/tests/022/data | false | an invalid URI though valid URI reference                                        |
        | #/000/tests/023/data | false | an invalid URI with spaces                                                       |
        | #/000/tests/024/data | false | an invalid URI with spaces and missing scheme                                    |
        | #/000/tests/025/data | false | an invalid URI with comma in scheme                                              |
