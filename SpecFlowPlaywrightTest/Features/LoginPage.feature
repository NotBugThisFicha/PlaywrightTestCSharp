Feature: LoginPage

@smoke
Scenario: TestLoginOperationDesiiign
    Given I navigate 
	And I click login link
	And I fill login details
	  | USERNAME | PASSWORD |
	  | admin    | password |
	Then I authorize