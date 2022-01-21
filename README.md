

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

An android phone to test [Phone setup on Xamarin](https://dotnet.microsoft.com/en-us/learn/xamarin/hello-world-tutorial/devicesetup) :
 - A physical phone with USB debugging enabled [Link to USB debugging](https://www.frandroid.com/comment-faire/tutoriaux/229753_questcequelemodedebogageusb)
 - Or an emulator (used below)

#### To open documentations
- Balsamiq Wireframe / Mockup
- Draw.io / Diagrams.net
- Astah Community / UML

## First build and deploying
Clone the project
``` bash
git clone https://github.com/EliottJaquierCPNV/Scannergic.git
```
Make sure git lfs is installed (git lfs is used for the images in this project)
``` bash
git lfs install
```
Switch the 'develop' branch
``` bash
git checkout develop

```
Open your project is visual studio (Project in /ScannergicMobile/ScannergicMobile.sln)

Wait a few minutes until all prerequisites are initialized

Compile your project

Run the tests (see the 'Note for tests' section before running)

![unknown](https://user-images.githubusercontent.com/61775618/149953861-056e560f-6f79-4e60-b3a8-acbcb2fea920.png)

#### Deploying on emulator
Click on the play icon to setup an emulator

![unknown](https://user-images.githubusercontent.com/61775618/149953423-5e64c309-6dc5-4f20-b5ea-da1220b5e4b4.png)

Create the default emulator

![unknown](https://user-images.githubusercontent.com/61775618/149954391-97e36a6a-3e15-4279-8fef-657a7a62994d.png)

Wait until the download is complete

![unknown](https://user-images.githubusercontent.com/61775618/149954459-cffba424-481b-4954-83f2-22ec3705903a.png)

Start for the first time the emulator

![unknown](https://user-images.githubusercontent.com/61775618/149954536-0b964de2-6ada-4709-b1ab-d2a96f4b3986.png)

When the emulator is started, click on the new play button in Visual Studio.

![unknown](https://user-images.githubusercontent.com/61775618/149954617-f8dc1884-c55f-421f-8282-b3fac6fd27a5.png)

If you have a deployment error, look at the points below:
- Make sure you have started the emulator (it should be on the home page)
- Try deploying again 1 minute after the first failed deployment. (In some cases, the first deployment fails because it activated an emulator initialization procedure) 
- You don't have a valid key for the application (See 'Note for deploying')

From now on, the application should run on the emulator! See the 'Note for the scan' section during the first scan.

### Note for tests
For the tests to succeed, the url 'https://scannergic.diduno.education/' must be accessible (it may not work depending on the schedule)

If the API (Scannergic.diduno.education) is not accessible, all tests will succeed except those contained in the test class 'TestApiRequest'

### Note for the scan
During the first scan and camera permission request, the application crashes. This is a known bug. Restart the application and the scan will work perfectly.

![image](https://user-images.githubusercontent.com/61775618/149954955-d8377eb9-e2c0-44f2-a383-731a66d0d32b.png)
![image](https://user-images.githubusercontent.com/61775618/149955242-46be3b88-987b-4120-8186-d5f8a218e1b3.png)

To use the camera in emulator mode, maintain ALT.
Move the mouse to move the head and press W,A,S,D to move

![image](https://user-images.githubusercontent.com/61775618/149956031-5c7a496a-1da6-4a20-9dba-61528e2f8d9e.png)

For scanning a product, you will need to change the image in the emulator. Go to the settings/camera/ and add the product EAN13 code. (Under Doc\TestEAN13Code, you will have the demo codes)

![image](https://user-images.githubusercontent.com/61775618/149956223-af94204d-c322-4140-80b7-82144c0ad1fd.png)

![image](https://user-images.githubusercontent.com/61775618/149956334-a9ed522f-99c7-4cbd-808b-0ade4f918d80.png)


### Note for deploying

If you want to sign you app for deployement or you have an error like this :	XA4310: `$(AndroidSigningKeyStore)` file `...` could not be found (This mean that the project a signing key. The key is not on the depot for security), you will need to change the key or delete it.

![image](https://user-images.githubusercontent.com/61775618/150487703-a1fa3bf2-6bd3-48ac-9cb5-d554daea37ac.png)

Change it or disable the option.

![image](https://user-images.githubusercontent.com/61775618/150486463-a9c0fee8-e87a-4a29-a674-597d60707a92.png)
