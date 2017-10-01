Feature: Gig
	I want to assure that all gig requests happen without issues

Scenario: Create a move Gig
	Given the following Gig
	| UserId | Label    | Description         | Date       | Bounty | Pickup | Destination |
	|        | Delivery | Deliver Playstation | 2017-02-01 | 100    | JHB    | PE          |
	Then I should see the following gig in the database
	| UserId | Description         | Date       | Bounty |
	|        | Deliver Playstation | 2017-02-01 | 100    |

