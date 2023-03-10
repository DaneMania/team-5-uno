
Feature: North

    I want to move my character North. If they attampt to 
    move past a boundary, the move results in no change in position.

    @acceptance
    Scenario Outline: Move in a direction

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player choses to move in <direction>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates<endingPositionY>
    Examples:
    | startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY |
    | 1 | 10 | North | 1 | 10 |
    | 1 | 1 | North | 1 | 2 |
    