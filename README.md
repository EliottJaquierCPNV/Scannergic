

# Scannergic (Frontend mobile client)
## Introduction

### General idea of the project

Our idea is to develop an android application which would allow people with allergies to fill them in the app, scan the barcode of a product and quickly know if they can eat the product or not. So the application knows, according to the different allergies, which product can be eaten or not.

### Goal

This application aims at simplifying people with allergies' life allowing them to quickly know if they can eat a product or not.
This android app will request the API of the 'Scannergic Backend' project and display the infos

### Schematic diagram (Frontend to bakcend)

![SchémadePrincipe2](https://user-images.githubusercontent.com/61775725/141955527-72237c5a-a55d-431d-a332-4cf52c142d89.png)

## Prerequisites to collaborate 
visual Studio (2019 community is used) with packages :
 - Mobile developpement .NET (Xamarin) [Install xamarin package](https://dotnet.microsoft.com/en-us/learn/xamarin/hello-world-tutorial/install)

An android SDK (included in android studio : https://developer.android.com/studio)

An android phone to test [Phone setup on Xamarin](https://dotnet.microsoft.com/en-us/learn/xamarin/hello-world-tutorial/devicesetup) :
 - A physical phone with USB debugging enabled [Link to USB debugging](https://www.frandroid.com/comment-faire/tutoriaux/229753_questcequelemodedebogageusb)
 - An emulator 

#### To open documentations
- Balsamiq Wireframe / Mockup
- Draw.io / Diagrams.net
- Astah Community / UML

#### First build and deploying
Clone the project
``` bash
git clone https://github.com/EliottJaquierCPNV/Scannergic.git
```
Make sure git lfs is installed (git lfs is used for the images in this project)
``` bash
git lfs install
```
Switch the 'developp' branch
``` bash
git checkout developp
```

#### Tests
For the tests to succeed, the url 'https://scannergic.diduno.education/' must be accessible (it may not work depending on the schedule)
If the API (Scannergic.diduno.education) is not accessible, all tests will succeed except those contained in the test class 'TestApiRequest'
