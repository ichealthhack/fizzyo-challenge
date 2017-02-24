# Thanks for entering the Microsoft Fizzyo Challenge

If you saw [episode 3 of the Big Life Fix](https://www.youtube.com/watch?v=d6A8R146JW) featuring the Coxhead family, you’ll have seen the connected Physio device (which we’ve affectionately dubbed ‘Fizzyo’) turning their daily Cystic Fibrosis exercises into video game sessions.

Our hope is the Fizzyo device this will motivate children to do their physio every day and potentially help other families with Cystic Fibrosis as well!

If you are a game developer it’s as easy as 1-2-3.

The Fizzyo device appears as a Joystick on the computer, so you simply need to have your game interpret joystick inputs.

We allow for 2 types of inputs:

 - Breath – This appears as the Horizontal axis of the joystick, (float) returns breath strength from (-1 – 1) with 0 being not breathing, > 0.7 blowing or breathing out hard and < -.5 breathing in hard
 
 - Button Press – We’ve added 1 button to the device to make game interactions a little more sophisticated. This button appears as Fire1 from a joystick control.

If you are developing in Unity, you can use the following commands:

```
//(bool) Will return if the Fizzyo button is pressed or not.
Input.GetButtonDown("Fire1");

//(float) returns breath strength from (-1 – 1) with 0 being not breathing,
          > 0.7 blowing or breathing out hard and < -.5 breathing in hard
Input.GetAxis("Horizontal");
```

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
