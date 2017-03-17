using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartCalibrate : MonoBehaviour
{
    //public 
    public Text startText;
    public GameObject pressureBar;
    public ParticleSystem particleSystem;

    //private
    private float maxPressureReading = 0;
    private float minPressureThreshold = 0.1f;

    private System.Diagnostics.Stopwatch blowingStopwatch;
    private int countdownToStart = 3;
    private float smoothing = 0.05f;

    // Use this for initialization
    void Start()
    {
        // Create new stopwatch.
        blowingStopwatch = new System.Diagnostics.Stopwatch();
        startText.text = "" + countdownToStart;
    }

    // Update is called once per frame
    void Update()
    {
        float pressure = FizzyoDevice.Instance().Pressure();

        //animate breath particles
        particleSystem.startSpeed = pressure * 500;
        particleSystem.startLifetime = pressure * 1;

        //set pressure bar height
        float destHeight = -20 * pressure;
        float y = pressureBar.transform.localPosition.y + ((destHeight - pressureBar.transform.localPosition.y) * smoothing);
        pressureBar.transform.localPosition = new Vector3(pressureBar.transform.localPosition.x, y, pressureBar.transform.localPosition.z);


        if (pressure > minPressureThreshold)
        {
            maxPressureReading = pressure;
            blowingStopwatch.Start();
            int timeToStart = (int)(countdownToStart - (blowingStopwatch.ElapsedMilliseconds / 1000));

            if (timeToStart > 0)
            {
                startText.text = "" + timeToStart;
            }
            else
            {
                //Save the max recorded pressure to use to scale sensor input during gameplay.
                PlayerPrefs.SetFloat("Max Fizzyo Pressure", maxPressureReading);
                SceneManager.LoadScene("JetpackLevel");
            }
        }
        else
        {
            blowingStopwatch.Stop();
        }

    }
}
