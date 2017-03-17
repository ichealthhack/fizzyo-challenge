
# Example
### Scenes/StartCalibrate.unity
A simple example of pre-calibrating your game for use by different people with different lung strengths.
In this example the user is invited to blow steadily for 2 seconds to start the game, during this time the max blow strength is recorded and used to scale pressure values in subsequent levels.

### Scenes/JetpackLevel.unity
Breathing into the device propels a character into the air using a jetpack with the height of the character is mapped to the breath strength. The fizzyo's  button or spacebar can be used to fire missiles.


## Test Harness
This example includes a test harness and test data that allows you to load and playback breath data saved from a fizzyo device.
To use this a singleton class is provided FizzyoDevice.Instance() that can be used at any point in your code if FizzyoDevice.cs is present in your project.

By default FizzyoDevice plays back pre-recorded data but can also be used to gather data directly from the device if the bool useRecordedData is set to false.
This can be done through the editor or programmatically in your code.
[image]
This allows you to program your game completely against pre-recoreded pressure values if desired and switched over to live values at a later stage.



```
FizzyoDevice.cs

/* (float) Return the current pressure value, either from the device or streamed from a log file.
*   range: -1.0f - 1.0f
*   comment: if useRecordedData is set pressure data is streamed from the specified data file instead of the device.
*/
FizzyoDevice.Instance().Pressure();


/* (bool) Return if the fizzyo device button is pressed */
FizzyoDevice.Instance().ButtonDown();

```
