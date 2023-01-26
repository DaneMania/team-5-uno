Feature: North

    I want to move my character North. If they attampt to 
    move past a boundary, the move results in no change in position.

    @acceptance
    Scenario Outline: North
        Given the character at position with XCoordinates <startingPositionX>
        And start at YCoordinates <startingPositionY>
        And the player chose to move in <direction>
        When the character moves
        Then the character is now at position with XCoordinates <endidngPositionX>
        And YCoordinates <endingPositionY>
        Examples:
            | startingPositionX | startingPositionY | direction | endidngPositionX | endingPositionY |
            | 1 | 10 | NORTH | 1 | 10 |
            | 1 | 1 | NORTH | 1 | 2 |

