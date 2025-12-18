public class Modifications
{/*
    ░▒▓████████▓▒░▒▓█▓▒░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░        
    ░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ */

    /*  ================================================================
        AMAZING RACER
        ================================================================
        1 - directional light (colour, intensity, etc)
        modifications: 
            Changed the Color to Hex A500A4, to appear similar to the water.
            Raised the intensity to 1.65 to make it have some more impact on the surroundings.

        2 - fog
        modifications: 
            Set the fog density to 0.11 to reduce the player's view.
            Changed its color to Hex 404040 for a greyish hue.

        3 - create & apply skybox and customise it (atmosphere thickness, sky tint, exposure, etc)
        modifications: 
            Made a new Skybox named BlueSkiesPurpleSun under the materials folder.
            Set Sun Size to 0.09.
            Set Sky Tint to Hex 002EFF.
            As a last touch, set the Exposure to 0.22 for a somewhat night sky feel.

        PLAYER
        4 - create and attach a complex object comprised of 3 or more shapes and make it so that it is visible when the game is played.
        -If you're having trouble coming up with ideas, create a simple figure out of shapes like a Minecraft or Roblox character!
        modifications: 
            Created a humanoid figure comprised of 9 3D Capsules forming the body and 1 3D Sphere.
            Reized it to fit roughly within the collider of the Player asset.
            After renaming these assets and arranging them together, I then organized them into empty gameobjects for individual segments with associated names- all nested under the label of PlayerCharacter.
            Finally, to have some fun, I made a running animation for the PlayerCharacter and moved the camera back, up, and angled down to change the gameplay to third person.
            After that I nested the PlayerCharacter to the Player asset in the Hierarchy with plans on fine tuning the animation if I have time.
            
        5 - use gameobject hierarchy to keep it organised
        [no record necessary]
    */
    /*
            void PlayerCharacter
            {
                Head;
                Torso;
                LeftArm
                {
                    TopLeftArm;
                    BottomLeftArm;
                }
                RightArm
                {
                    TopRightArm;
                    BottomRightArm;
                }
                LeftLeg
                {
                    TopLeftLeg;
                    BottomLeftLeg;
                }
                RightLeg
                {
                    TopRightLeg;
                    BottomRightLeg;
                }
            }
    */
    /*
        FINISH ZONE
        6 - convert to prefab, create 2 variants, and add an instance of each variant around the scene
        modifications: 

        7 - modify the light component of the variants so that all have a different colour
        [no record necessary]

        8 - add a particle system component to the original prefab and customise at least 3 parameters
        -All instances will update to include the particle system
        -Don't forget to reassign any public fields on the instances to get them to work
        parameter 1: 
        parameter 2: 
        parameter 3: 

        TERRAIN
        9 - raise/lower to reshape and make it distinctly different from original
        modifications: 

        10 - paint with at least 2 new textures to replace all the textures used in the book
        (add source url or package name)
        texture 1 source: 
        texture 2 source: 

    */
}