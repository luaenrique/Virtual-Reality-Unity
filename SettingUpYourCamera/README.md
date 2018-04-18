# How to create a VR Camera in Unity 

## This file aims to help you to set up your VR Camera.


### 1. First, you have to download the GoogleVR SDK, you can check the link below to get the same version that I'm using

![Google VR SDK download](https://github.com/googlevr/gvr-unity-sdk/releases/download/v1.130.1/GoogleVRForUnity_1.130.1.unitypackage)

### Or if you prefer, you can get the link below to search which version you want

![I would like to search more options!](https://github.com/googlevr/gvr-unity-sdk/releases)


### 2. After download it, you need to import it into your Unity project, to do it you'll need to go to Assets>Import Package>Custom Package and search for GoogleVR SDK in your directories:

![](https://i.imgur.com/1LbtY7b.png)

### 3. Create an empty object in your Unity Scene, and put your main camera inside of it and put the GvrControllerMain, GvrEditorEmulator and the GvrEventSystem inside of your scene.

### 4. Now, search for GvrReticlePointer inside of your GoogleVR SDK Assets folder and drag and drop it inside of your main camera:

![](https://i.imgur.com/Fj2NssW.png)

### 5. Now, you just have to bind the Gvr Pointer Physics Raycaster Script inside of your main camera



Thank you to check this =).
