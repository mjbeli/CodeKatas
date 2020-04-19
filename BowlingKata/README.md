### BowlingKata 
inspired in https://kata-log.rocks/bowling-game-kata

A spare is when the player knocks down all 10 pins in two rolls. The bonus for that frame is the number of pins knocked down by the next roll. A strike is when the player knocks down all 10 pins on his first roll. The frame is then completed with a single roll. The bonus for that frame is the value of the next two rolls.

Write a class Game that has two methods
 - void roll(int, int) is called each time the player play a frame. The argument is the number of pins knocked down in each roll.
 - int score() returns the total score for that game.
