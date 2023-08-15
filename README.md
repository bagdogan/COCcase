# COCcase
HH Game Artist Case Study

Unity version: 2022.02.20f1

Task:
Character
1- Create a low-poly model of the Barbarian character from Clash of Clans
2- An animation of transferring the sword from one hand to the other will be created, and it will work seamlessly within Unity
3- Make sure that the character's areas like clothing are customizable in terms of color within Unity.

Building
1- Create the building in the software of your choice, render it, and then add it to Unity.
2- Create smoke effects coming out of the chimney of the building within Unity.

How did I do it?
Character
Model & Texture: ZBrush => Autodesk Maya => Substance Painter
Animation: Autodesk Maya => Unity

Animations created in Autodesk Maya can have the constraints property in Unity. Still, since there can be different scenarios within the game, using the Animation Rigging package available within the Unity Package would be more appropriate. This way, we can manipulate object positions without leaving Unity, such as picking up and dropping objects or changing hands.

*Install the Animation Rigging Package to use the Multi-Constraint Component.

*Please check Character Scene under the Character folder

Building

As the quickest solution, modeling, painting, and rendering were done using ZBrush. Corrections were made in Photoshop. The result was imported into Unity and a particle system was added.

*Please check Building Scene under the Building Folder.

