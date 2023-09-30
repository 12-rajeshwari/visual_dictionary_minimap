# visual_dictionary_minimap
The implementation of the minimap:
-Minimap_camera:
Create an empty game object named the "minimap_camera", which harnessed visual data from the primary camera while maintaining an orthogonal perspective view.
Then, the minimap camera was attached to the main camera as a child to ensure synchronized movement.

-Minimap_bike
Create an empty game object as the "minimap_bike", to facilitate the cyclist's awareness of their position and aligning it as a child to the bike game object which is responsible for bicycle movement.

-Minimap_car
Create an empty game object as the "minimap_car", for enhanced visibility of the positions and directions of moving cars located behind the cyclist, and attached it as a child to the car game object.

-Minimap layer
To effectively manage and render the positions of the cyclist and moving cars, we implemented a dedicated layer known as "minimap" (which would provide the flexibilty to render different topography and objects
that developer shows to make visible on minimap).

-Canvas
To convey this visual representation, I created a canvas with raw image to create a minimap_renderer texture and images to create minimap_mask and minimap_border  generated via a UI.
Furthermore, I used relevant free assets from the Unity Store to enhance the UI of the minimap.

Note:
It is very important to adjust the location of each component to make it visible on minimap when we start the project on play mode in unity engine.
