# Thanks for entering the Microsoft Fizzyo Challenge

Our hope is the Fizzyo device this will motivate children to do their physio every day and potentially help other families with Cystic Fibrosis as well!

If you are a game developer it’s as easy as 1-2-3.

The Fizzyo device appears as a Joystick on the computer, so you simply need to have your game interpret joystick inputs.

### We allow for 2 types of inputs:

 - Breath – This appears as the Horizontal axis of the joystick, (float) returns breath strength from (-1 – 1) with 0 being not breathing, > 0.7 blowing or breathing out hard and < -0.5 breathing in hard
 
 - Button Press – We’ve added 1 button to the device to make game interactions a little more sophisticated. This button appears as Fire1 from a joystick control.

### If you are developing in Unity, you can use the following commands:

```
//(bool) Will return if the Fizzyo button is pressed or not.
Input.GetButtonDown("Fire1");

//(float) returns breath strength from (-1 – 1) with 0 being not breathing,
          > 0.7 blowing or breathing out hard and < -0.5 breathing in hard
Input.GetAxis("Horizontal");
```
##Example of Bluetooth Joytsicks which can be used to replicate the devices

Analogue Joystick input is required. 

[Motionjoy® Mini Wireless Bluetooth Joystick GamePad Controller Selfie Remote Shutter for IOS Android Phone PC Tablet VR (Black)] (https://www.amazon.co.uk/gp/product/B01AI9CZVE/ref=oh_aui_detailpage_o01_s01?ie=UTF8&psc=1)

[VR Wireless Bluetooth Remote Gamepad Controller for Android IOS Phone Tablet] (https://www.amazon.co.uk/gp/product/B01LZJ3ZLU/ref=oh_aui_detailpage_o01_s00?ie=UTF8&psc=1)


##Typical Physio Sequence
- 9 - 10 cycles of the following routine
- Long slow breadth in until lungs are full (typically 2 sec depending on size of child)
- Hold the breadth 
- Exhale out active but not forced (typically 3 secs in length maintained velocity) 
- Then a huff/cough (the device is typically removed) This is forceful and the most important as its part of airway clearance (can this be used with your game)

##Game Types - think about the exercise

###Games children have suggested
- Bowling/firing a object (Breadth to charge)
- Geometry Dash/Flappy Bird (Jumping or movement)
- Angry Bird (Breadth to charge/fire)

## Game requirements

Keep in mind that we don’t want to force the children to blow to a certain pressure or for a certain amount of time. This is really up to the individual doing the exercises, we just want to detect a blow.

Designing a game for these limited interactions can be challenging! A good play pattern has been to use the blow to propel the character forward (at a constant speed) and the button to jump or fire a weapon.

In relation to output of the games from Health Hack we would like to implement a specific requirement / specification of games for use with the Fizzyo devices.

## Hardware and test data being provided

- We will be making available 3 x Fizzyo PEP Engineering devices to hacker for testing of game content

- We will be making available 3 x Fizzyo Acepella Engineering devices to hacker for testing of game content

- We will be providing a Unity Sample Game which shows the input methods

- We will be providing a sample data set of captured results from the devices for games testing

- We will be providing a Unity test harness for importing test data into developed games.

## How the Devices are used by Patients and how this should be related to game play

- Although getting a decent sized breath during inspiration is important – most of the focus is on expiration (this is the part where airway clearance is most effective).

- Inspiration is ‘free’ and un-resisted in all three techniques – while all 3 devices provide resistance against expiratory airflow 
(providing ‘positive expiratory pressure’ or PEP)

- PEP provides a consistent and measureable resistance against expiration

- Acapella and Flutter provide oscillatory resistance (Acapella with a magnetic lever and Flutter with a ball valve)

- Children aim for ‘active’ expiration rather than ‘relaxed or elastic recoil’ expiration(which is what happens normally). This means consistent, steady flow at a higher velocity than usual but not forced breathing.  

- Children aim for prolonged steady expiratory flow of at least 3s (although this may be a bit shorter in small children or those with severe disease who are breathless)

- The resistance in mid expiration for PEP should be 10-20cm H2O (ideally 12-15) measured by PEP manometer (in circuit) for mid-part of expiration.

- Treatments usually consistent of a series of ‘cycles’ – One cycle might typically include say 8-10 breaths through device (PEP & Acapella & Flutter ) as described above, followed by fewer but more forceful huffs (often not through the device- although some will huff through their PEP) and coughing as needed. The cycles are repeated until the chest feels clear. 

- Typical sessions should last no longer than 20 minutes.

- There needs to be a threshold for effort for an active blow (so that it doesn’t just respond to normal passive expiration) 

- It is important that we don’t incentivise more effort but do motivate for a longer blow, eg. acceleration could increase the longer the blow but definitely not accelerate with increased effort beyond the threshold trigger point.

## Useful videos on Patient physio and technique

- [Which is the best Airway Clearance method for Cystic Fibrosis?](https://www.youtube.com/watch?v=Wn5o5AgD9m0)
- [Cystic fibrosis breathing techniques – acapella device](https://www.youtube.com/watch?v=DJFp6A_p2R8)
- [Cystic fibrosis breathing techniques – positive expiratory pressure (PEP) mask](https://www.youtube.com/watch?v=C1SLdjvNg9U)

##Cloud Services & Backend

- All attendees will be provided with [Microsoft Azure](https://azure.microsoft.com) you will recieve $100 credit per month for 6 months 

- If you develop any cloud services please ensure all necessary scripts, database schema and scripts are added to the github repo.

- If your new to Azure you watch this quick webinar [How to Get Started on Azure](https://info.microsoft.com/UK-MSFT-WBNR-FY17-11Nov-24-HowtoGetStartedonAzure-269444_Registration.html)

- Azure cloud services offer you the ability to add storage, game save, leaderboards, High Scores.

- [More Detail on Azure Cloud for Gaming] (https://azure.microsoft.com/en-us/solutions/gaming/)

##Useful Resources for Cloud Gaming

###Service Fabric Opensource Gaming Framework
[What is Servcie Fabric] (https://azure.microsoft.com/en-us/services/service-fabric/)
[Open Source Gaming Framework with scalable, SignalR gateway] (https://github.com/SthlmTechAngels/GDC2017ServiceFabric) 
[Unity Tanks demo, becomes multiplayer with Service Fabric] (https://github.com/SthlmTechAngels/GDC2017Unity3d)

###Azure SDK and tools

[Unity Azure SDK] (https://github.com/Unity3dAzure)
[Using App Services to Create a Leaderboard] (http://www.deadlyfingers.net/azure/azure-app-services-for-unity3d/)
In future you can add Windows 10/Xbox Live Creators Update - [Add Xbox Gaming Features to your game - In Preview] (https://developer.microsoft.com/en-us/games/xbox/xboxlive/creator)

## Hack entry specific requirements for this challenge

- All output from Health Hack will be under GNU open-source licensing and all entries stored within [this organisation](https://github.com/ichealthhack).

- All games should be ideally developed to become cross platform iOS, Android, Windows 10 and Windows Desktop the input for the game will use Phyiso equipment specially PEP and Acapella devices.

- Our recommendation is that Unity3D is preferred development tool due to extensive cross platform support.

- Games are intended for an age range of 4 – 18 year olds

- Games should ideally include a competitive element so multiple or compete based games

- Games should ideally include a leaderboard service to allow children to compete

- Games can have a chat aspect but ideally this should be done within controlled gaming environments such as google play, Xbox live or Apple Game Center to ensure privacy.

- Microsoft Azure Cloud services will be provided to all attendees to add cloud need services to the hack entries.

## Submission and Judging requirements

- A brief presentation on the purpose of your game and how to use it.

- Uploaded source control as per the requirements

- A live demo for judges to experience game app and ask questions 

- All code and scripting must be done during the time of the hackathon

- Existing Unity Assets from the asset store must be described and listed prior to judging and clearly listed as additional assets' with installation instructions on the GitHub repo

- Art assets such as pictures, picture libraries, 3d models or sound/music files are allowed but must be listed as such prior to judging and referenced within GitHub repo

- No copyrighted materials are submitted to GitHub repo

- Input from the pep devices should be mapped to Unity3D joystick controls

- Details of the games architecture and database schemas should be documented within the submissions

## Prizes for best Hack Entry

- [Microsoft Band 2](https://www.microsoft.com/microsoft-band/en-gb)
- [Microsoft Adafruit Feather M0 Kit (Arduino-compatible)](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-adafruit-feather-m0-wifi-kit-arduino-get-started)
- Microsoft Goodie Bag
- Microsoft T Shirt
- Microsoft Xbox Onezie
