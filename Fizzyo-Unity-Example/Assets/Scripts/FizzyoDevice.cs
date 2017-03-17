using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Timers;
using UnityEngine.UI;

public class FizzyoDevice : MonoBehaviour
{
    //public 
    public bool useRecordedData = true;
    public bool loop = true;
    public string recordedDataPath = "Data/FizzyoData_3min.fiz";
    public Text debugTextPressure = null;

    //Singleton
    private static FizzyoDevice instance;
    private static object threadLock = new System.Object();

    //protected
    protected StreamReader fileReader = null;
    protected string text = " "; // assigned to allow first line to be read below
    System.Timers.Timer pollTimer = new System.Timers.Timer();
    float pressure = 0;


    public static FizzyoDevice Instance()
    {
        if (instance == null)
        {
            lock (threadLock)
            {
                if (instance == null)
                {
                    instance = GameObject.FindObjectOfType<FizzyoDevice>();
                }

                if (instance == null)
                {
                    instance = (new GameObject("EasySingleton")).AddComponent<FizzyoDevice>();
                }

            }
        }
        return instance;
    }


    // Use this for initialization
    void Start()
    {
        //Open a StreamReader to our recorded data
        try
        {
            fileReader = new StreamReader(Application.dataPath + "/" + recordedDataPath);
        }
        catch (Exception ex)
        {
            Debug.Log("could not load file " + recordedDataPath + " " + ex.ToString());
        }
        finally
        {
            Debug.Log("file loaded " + recordedDataPath);
            pollTimer = new Timer();
            pollTimer.Interval = 300; //load new pressure val every 30ms 
            pollTimer.Elapsed += PollLoggedData;
            pollTimer.Start();

        }

    }

    //Cleanup  
    void OnApplicationQuit()
    {
        //Close file pointer 
        fileReader.Close();

        //Stop Timer 
        pollTimer.Stop();

        Debug.Log("OnApplicationQuit");

    }
    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// If useRecordedData is set to false pressure data is streamed from the device or streamed from a log file if set to true.
    /// </summary>
    /// <returns>pressure data reported from device or log file with a range of -1 - 1.</returns>
    public float Pressure()
    {
        if (useRecordedData)
        {
            if (debugTextPressure != null)
            {
                debugTextPressure.text = String.Format("{0:0}", pressure * 100);
            }
            return pressure;
        }
        else
        {
            float p = Input.GetAxisRaw("Horizontal");
            if (debugTextPressure != null)
            {
                debugTextPressure.text = String.Format("{0:0}", p * 100);
            }
            return p;
        }
    }

    public bool ButtonDown()
    {
        return Input.GetButtonDown("Fire1");
    }


    void PollLoggedData(object o, System.EventArgs e)
    {
        if (text != null)
        {
            text = fileReader.ReadLine();
            string[] parts = text.Split(' ');
            if (parts.Length == 2 && parts[0] == "v")
            {
                float pressure = float.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture.NumberFormat) / 100.0f;
                this.pressure = pressure;
            }

            if (loop && fileReader.EndOfStream)
            {
                fileReader.DiscardBufferedData();
                fileReader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            }
        }
    }


}
