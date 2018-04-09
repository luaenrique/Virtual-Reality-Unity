# How to create a Timed Gaze Input w/ a Loading Bar using Unity Google VR SDK

Note: I am supposing that you already have setted up your VR camera in unity.

![alt text](https://i.imgur.com/qXW2Kb2.gifv)


To do it, you will need an image to be your loading bar, I've used this one:

![alt text](https://i.imgur.com/rHM064d.png)

Then you need to upload it to unity and set it as a Sprite:

![alt text] (https://i.imgur.com/aof5zTE.png)

Now, you'll need to create a canvas and inside of it you create an image:

![alt text](https://i.imgur.com/vPSb4Ju.png)

Then you have to put your sprite inside of the image component as a source image:

![alt text](https://i.imgur.com/3Z3BlM9.png)

Now you have to drag and drop your canvas to your script (You can check the file "TimedGazeScript" and follow it to build your code)!

![alt text](https://i.imgur.com/38n18RV.png)

I am also using "myTime" to control the bar through deltaTime function in C#.

Thank you for visit this repository, if you have any questions, please send me a message and I'll answer you as soon as possible.
