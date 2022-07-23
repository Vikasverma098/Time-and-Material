Feature: EmployeeFeature

As a TurnUp portal admin 
I Would like to create, edit and delete employee's records
So that I can manage employee's profile successfully.

@tag1
Scenario:01) Create Employee's data with valid details
	Given I logged inti TurnUp Portal successfully
	When I navigate to employee's feature page
	When I create a new employee record
	Then the record sholud be created successfully

@tag2  
Scenario Outline: 02) Edit Employee's data with valid details
 Given I logged inti TurnUp Portal successfully
 When I navigate to employee's feature page
 When I Update '<Name>' and '<UserName>' of an employee's record
 Then The record should have '<Name>' and '<UserName>' Updated



 Examples: 
 | Name  | UserName |
 | Teepu | Sultan   |
 | Las   | Vegas    |

@tag3
Scenario:03) Delete existing employee's record with valid details
 Given I logged inti TurnUp Portal successfully
 When I navigate to employee's feature page
 When I deleted an existing record
 Then the record sholud be deleted sucessfully