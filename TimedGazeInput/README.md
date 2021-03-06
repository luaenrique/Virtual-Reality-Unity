# How to create a Timed Gaze Input w/ a Loading Bar using Unity Google VR SDK

## My unity version: Unity 2017.2.2p2 (64-bit)


Note: I am supposing that you already have ![setted up your VR camera in unity.](https://github.com/luaenrique/Virtual-Reality-Unity/tree/master/SettingUpYourCamera)

![gif](https://i.imgur.com/zPq3zdm.gif)


To do it, you will need an image to be your loading bar, I've used this one:

![loading bar](https://i.imgur.com/rHM064d.png)

Then you need to upload it to unity and set it as a Sprite:

![setting up a sprite](https://i.imgur.com/aof5zTE.png)

Now, you'll need to create a canvas and inside of it you create an image:

![creating the canvas component](https://i.imgur.com/vPSb4Ju.png)

Then you have to put your sprite inside of the image component as a source image:

![](https://i.imgur.com/3Z3BlM9.png)

Now you have to drag and drop your canvas to your script (You can check the file "TimedGazeScript" and follow it to build your code)!

![d&d](https://i.imgur.com/38n18RV.png)

I am also using "myTime" to control the bar through deltaTime function in C#.

Thank you for visit this repository, if you have any questions, please send me a message and I'll answer you as soon as possible.
