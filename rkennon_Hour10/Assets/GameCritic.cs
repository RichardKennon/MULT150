/*      Improving the Game
The game is too hard. In the chaos of the balls bouncing around, gaining and losing speed, it's already hard to pinpoint the whereabouts of the goal balls
and even harder to reach them, requiring the player to predict their bounce location and meet it at a desired angle since the player doesn't have much speed.

I think the game would be easier if a slow motion action key could be pressed where the player can fine tune the angle of their barricade before the ball reaches them.
If possible, I would make it so there was an indicator of which direction the balls would bounce during the slow motion phase, so people without experience with such games
would actually have use of the formentioned feature.

I'd imagine the slow motion would also count as a wow feature, however a few other suggestions to make the game more exciting would be as follows:
1. Turn the walls into a well lit encasing box and remove the y axis lock while also giving the player uninhibited 3 dimensional movements, adjusting the code, enlarging
asset sizes, and increasing player speed so the game doesn't increase in difficulty.
2. Make the player's Bouncer wall change in shape at set intervals. Whether random or procedural, this will require the player to plan ahead in a more entertaining way or
risk finding themselves bouncing balls in radically unintended directions.
3. Make the water rise and fall and incure some kind of affect on the balls or player, such that the affect changes the way the player and/or balls move but not increase
or decrease the difficulty.

The game doesn't feel particularly fun to me, I don't even feel a sense of accomplishment. Tedious factors of the game are trying to keep up with the ball, and the
game will end less due to your own contribution and more due to the balls happening to bounce into their respective goals in the chaos
-After making improvements to the player's ability to affect the gameplay, I'd make it impossible for the color balls to trigger their respective goals without having
 first bounced on the bouncer one or two bounces prior to indicate that the player had indeed caused the ball to land in the goal.

*/

/*      Exercise
 1. I implimented a reset mechanic after the game is over as a click interface and enter key.
I also managed to code a way into reaching the game over screen faster for testing purposes by adding a override to the GoalScript, forcing an isSolved = true; senario
with the Update method when the R key was pressed down.
-I couldn't figure out how to do it from the GameManager script, as the original code of isSolved kept overriding my efforts to influence the isGameOver bool directly.

  2. Time counter was implimented to appear as an rounded integer displayed at the top left of the screen. elapsedTime set to keep counting the passage of time while
isGameOver remained false, stopping the timer with the game's end.

  3 & 4. The Bumper's size was increased in scale and given three additional bumper walls, giving it a more complex shape. While technically meeting two of the four
criteria in the assignment in a half hearted way, the reason I finished with this is due to the purpose these changes were designed for that took me a fair deal of time.
-Attached to the BumperGate 3D object of the Bumper is my solution to the player's restricted influence over the gameplay, a script called GateKeeper which allows the
player to press the space button to disable or enable the object's collider and mesh render such that they might grab the bouncing colored balls and hold them inside the
barriers long enough to aim at one of the corners and release it in an intended direction. This has proven decently more effective than chasing down speeding balls.
 */