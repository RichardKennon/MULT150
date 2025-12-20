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
            Set the fog density to 0.06 to reduce the player's view.
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
            Turned the Finish Zone into a Prefab- And made a tent out of it.
            Created two variants named Finish Zones VarianRed and VarianBlue, and added a colored material on both to distinguish them further.
            Placed Finish Zone Variants at the end of two new jumping puzzles made using the terrain.

        7 - modify the light component of the variants so that all have a different colour
        [no record necessary]
            Set one to red, the other to blue.

        8 - add a particle system component to the original prefab and customise at least 3 parameters
        -All instances will update to include the particle system
        -Don't forget to reassign any public fields on the instances to get them to work
        parameter 1: Enabled Size over Lifetime and set it to start full size and shrink into nothing.
        parameter 2: Adjusted existing parameters, Start Liftetime, Start Speed, Rate over Time, as well as Shape Angle and Shape Radius to give the appearance of the particles flowing out of the tent.
        parameter 3: Enabled Trails and tinkered with the settings, giving it the same Default Particle Material as nothing else seemed to work out to my liking.

        TERRAIN
        9 - raise/lower to reshape and make it distinctly different from original
        modifications: 
            First I flattened the obstacle course, hidding the water hazard from view.
            Through the use of the Hexagon shaped brush and a combination fo the Stamp Terrain and Set Height controls I completely reshaped the map.
                -Made hexagon shaped lakes of varying sizes and depths for the player to fall into.
                -Reshaped the mountains that block the player from leaving the world into tall, sheer cliffs roughly hexagon shaped.
                -Made hexagon shaped cliffs between the lakes to act as obstacles.
                -Made 2 hexagon mountain jumping courses to place the variant finish zones at the end.
        10 - paint with at least 2 new textures to replace all the textures used in the book
        (add source url or package name)
        texture 1 source: https://www.bing.com/images/search?q=&view=detailv2&id=B217BFFCA9AC7C3D38303EE3329F6275ACBC4A9F&ccid=4poBLpMK&iss=fav&FORM=SVIM01&idpview=singleimage&mediaurl=https%253a%252f%252fwww.sketchuptextureclub.com%252fpublic%252ftexture_m%252f0065-stainless-metal-plate-texture-seamless.jpg&expw=280&exph=280&thid=OIP.4poBLpMK8EkqqcmTL-_RYwHaHa&idpbck=1
        texture 2 source: https://www.bing.com/images/search?q=&view=detailv2&id=7EC95F3D069A4B52485A73171E84A4DD845404B8&ccid=axaEHeLE&iss=fav&FORM=SVIM01&idpview=singleimage&mediaurl=https%253a%252f%252fimg.freepik.com%252fpremium-vector%252fabstract-shiny-metal-background-silver-color-with-circular-brushed-texture-hexagonal-holes_444390-4208.jpg&expw=626&exph=626&thid=OIP.axaEHeLEjqGno9SzOBs44wHaHa&idpbck=1
    -Side note, I should have found the Hexagon texture first, it actually makes it easier to be certain I got the right shape.
    */
}