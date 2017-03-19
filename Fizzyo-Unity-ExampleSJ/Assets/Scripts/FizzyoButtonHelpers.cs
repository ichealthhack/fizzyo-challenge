using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A delegate type for hooking up button hold event handlers
public delegate void ButtonHeldEventHandler(FizzyoDevice sender, float duration);

/// <summary>
/// Attach this component to an object to take advantage of helpers around
/// <see cref="FizzyoDevice.Button"/>. Currently provides access to information
/// about button hold and useful events based on hold duration.
/// </summary>
public class FizzyoButtonHelpers : MonoBehaviour
{

    private FizzyoDevice device;
    private bool wasDownInPreviousUpdate = false;
    private float buttonDownSince = -1;

	void Start ()
    {
        device = FizzyoDevice.Instance();
	}
	
	void Update ()
    {
        bool buttonDown = device.Button();

        if (buttonDown)
        {
            if (!wasDownInPreviousUpdate)
            {
                // Start of a press (remember start time)
                buttonDownSince = Time.time;
                wasDownInPreviousUpdate = true;
            }
            else
            {
                // Raise held event
                OnButtonHeld(ButtonHeldDuration());
            }
        }
        else if (!buttonDown && wasDownInPreviousUpdate)
        {
            // Reset tracking of hold duration
            buttonDownSince = -1;
            wasDownInPreviousUpdate = false;
        }
	}

    /// <summary>
    /// The button hold duration in seconds. Will be 0 if currently not holding.
    /// </summary>
    public float ButtonHeldDuration()
    {
        return buttonDownSince != -1 ? Time.time - buttonDownSince : 0;
    }

    /// <summary>
    /// True if the button has been held for at least <paramref name="duration"/>
    /// seconds at the time of calling this method.
    /// </summary>
    /// <param name="duration"></param>
    /// <returns></returns>
    public bool ButtonHeld(float duration)
    {
        return device.Button() && (Time.time - buttonDownSince >= duration);
    }

    /// <summary>
    /// Invokes callbacks when button is held down for at least two consequtive frames.
    /// </summary>
    /// <param name="sender">The Fizzyo device</param>
    /// <param name="duration">The hold duration in seconds, calculated through <see cref="Time.time"/></param>
    public event ButtonHeldEventHandler ButtonHeldEvent;
    protected virtual void OnButtonHeld(float duration)
    {
        if (ButtonHeldEvent != null)
        {
            ButtonHeldEvent(device, duration);
        }
    }

    /// <summary>
    /// Invokes <paramref name="handler"/> once when button is held for at least
    /// <paramref name="minDuration"/> of seconds. W<paramref name="handler"/> won't be
    /// invoked until the button is released and held for <paramref name="minDuration"/>
    /// again.
    /// </summary>
    /// <param name="minDuration"></param>
    /// <param name="handler"></param>
    public void OnButtonHeldFor(float minDuration, ButtonHeldEventHandler handler)
    {
        bool raised = false;
        ButtonHeldEvent += (device, duration) =>
        {
            if (!raised && duration >= minDuration)
            {
                handler(device, duration);

                // Make sure we don't call handler twice for the same hold event
                raised = true;
            }
            else if (raised && duration < minDuration)
            {
                // Reset because this is a new hold and handler should be called
                // if duration reaches minDuration
                raised = false;

                // It is possible to add a "released" handler overload which would
                // be called here
            }
        };
    }
}
