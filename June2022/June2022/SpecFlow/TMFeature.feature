Feature: TMFeature

As a TurnUp portal admin 
I Would like to create, edit and delete time and material records
So that I can manage employee's time and material successfully.

@Create
Scenario: 01) create material record with valid details
	Given I logged into TurnUp portal successfully
	When I navigate to time and meterial page
	When I create a new material record
	Then the record should be created successfully


@Edit
Scenario Outline: 02) edit existing material record with valid details
	 Given I logged into TurnUp portal successfully
	 When I navigate to time and meterial page
	 When I update '<Code>', '<Description>' and '<Price>' of an existing material record
	 Then the record should have the '<Code>', '<Description>' and '<Price>' updated

  Examples: 
  | Code     | Description |   Price    |
  | Keyboard | White       | $150.00    |
  | Bottle   | Green       | $1,089.00  |
  | Pen      | Blue        | $5.00      |

@Delete
  Scenario: 03) Delete existing material record with valid details
  Given I logged into TurnUp portal successfully
  When I navigate to time and meterial page
  When I delete an existing record
  Then The record should be deleted successfully