/*
public class GameCritic : MonoBehaviour
{
    string Question1 (Is the game too easy or hard?)
    {
        return "Rather than difficult or hard, it just feels boring. It doesn't feel like
        you're trying to achieve anything, the time I lasted whether 10 seconds or 60 didn't
        make me 'feel' accomplished, so I couldn't decide how long the gameplay needed to be
        feel me to think it was to hard or easy to last up to a certain point.";
    }

    string Question2 (What changes would you do to make it easier or harder?)
    {
        Invoke("Question3", Refer to Question1() );
        
        return "After making the game more appealing, I would adjust the variables and make
        changes to the player's animation. The shield effect needs some kind of timer or
        visible indicator of when it will run out so players don't need to adjust to having
        a 'gut feeling' of when to use it and when it will run out. It wasn't fun missing
        power-ups for me when phasing through obstacles. Changing up the timing of the
        variables and adding indicators for timed actions should be able to make the game
        feel more difficult or easier as needed.";
    }

    string Question3 (What would make the game more appealing?)
    {
        return "Add more variables and game mechanics.";

        return "First and formost: A SCOREBOARD, a UI menu screen that contains the best
        times of yourself and other players by virtue of a logging system and player name
        input screen- the kind you'd see from arcade machines. If there's someone to compete
        against, whether it's yourself or a friend, the time your survived gains a new meaning.";

        return "With variables, I'd keep things simple after adding the potentially complicated
        scoreboard by adding more powerups and obstacles, reusing the same Collidable script
        set to be harder to intercept and thus grant more time or easier to avoid and lose
        more time.";
    }

    string Question4 (What parts of the game are fun?)
    {
        Invoke("Question1", game would have to be interesting to be fun);

        return "While the game has potential, the way it is in its 'prototype' form makes
        it not particularly appealing in any way.";
    }

    string Question5 (What parts of the game are tedious?)
    {
        return "The invicibility, or 'phasing' state triggered by jumping doesn't feel
        satisfying and feels like just as much as a hinderance as it is an asset. Using
        it means the obstacles can't hurt you, but also means the powerups can't help you.";
    }

    void gameChanges()
    {
        if ( reference == obstacle )
        {
            Deciding against tampering with the obstacles foundation as to not influence gameplay apart from recoloring,
            I created 2 new materials and 4 more cubes that I attached to the prefab as child objects, having first
            reshaped and renamed each object to match its intended purpose on the prefab.

            Next, I moved the cubes to hover a short distance above the base obstacle and used 3 of them to encase
            the forth, adding the MetalChassy material to them that utilized the metal floor Texture with a different
            tiling. With the fourth cube now obscured, I sourced a robot face image online and formatted it as a .png
            to use on my second new material named "MachineHead" that I applied to the forementioned encased cube.
            I then tiled the material's texture, as well as the child object's rotation, till only one portion of the texture
            face was exposed to the player's view.
            
            Finally I scaled up the prefab's nested "MachineHead" so that the robotic texture was clearly visible to the player
            during gameplay while also making it more threatening. Thus, the levitating, mechanical attackers were born.
            https://cartoondealer.com/image/96192711/robot-face-icon-smiling-angel-face-emotion-robotic-emoji.html
        }
        else if ( reference == powerup )
        {
            First I changed the sphere to a capsule in both mesh and collider and I scaled it up, particularly in length, so
            that it was easier to hit. I also rotated onto its side, being careful not to break the code that directed its
            movements.
            As for the particle system, I started by changing the start color to a light-blue color, Hex 80AFFF, for which
            I also set the material and light component to match.
            Next, I changed the Renderer to a sphere mesh and the material to the provided asset, "PhasedOut".
            For the finishing touch, to make it truely unique, I changed the Shape to Donut and the Emission's Rate over Time to 40.
            Donut()
            {
                Radius = 0.3;
                Donut Radius = 1.69;
                Arc()
                {
                    Mode = Loop;
                    Speed = -0.17;
                }
            }
        }
    }

}
 */

// This might be easier to read by removing the /* */ marks and compacting it to what your reading. Really, I just had my own little fun with the GameCritic, so I hope it isn't too hard to read.