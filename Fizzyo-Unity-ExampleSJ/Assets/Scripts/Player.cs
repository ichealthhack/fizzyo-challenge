using UnityEngine;

public class Player : MonoBehaviour {

    //public
    public float maxHeight = 5f;
    public GameObject missilePrefab;

    //private
    float destXSpeed = 0.02f;
    public float maxFizzyoPressure = 0.5f; //calibrated on start screen
    public float smoothing = 0.1f;
    private float xSpeed = 0f;

    // Use this for initialization
    void Start () {

        //load our sensor calibration if already set
        if (PlayerPrefs.HasKey("Max Fizzyo Pressure"))
        {
            maxFizzyoPressure = PlayerPrefs.GetFloat("Max Fizzyo Pressure");
            Debug.Log("Set max fizzyo pressure val to: " + maxFizzyoPressure);
        }

    }

    // Update is called once per frame
    void Update () {
        //get the pressure value of our fizzyo device communicated as a joystick axis 0-1 blow out -1-0 breath in
        //float fizzyoVal = Input.GetAxisRaw("Horizontal");

        //get the pressure value from our fizzyo device or logged pressure data if useRecordedData is set to true.
        float pressure = FizzyoDevice.Instance().Pressure();

        float destHeight = maxHeight * Mathf.Min((pressure / maxFizzyoPressure), 1);
        float y = transform.position.y + ((destHeight - transform.position.y) * smoothing);

        float x = transform.position.x;
        if (y > 0.1f)
        {
            xSpeed += (destXSpeed - xSpeed) * smoothing;
            x += xSpeed;
        }
        else
        {
            xSpeed = 0;
        }
        transform.position = new Vector3(x, y, transform.position.z);

        if (FizzyoDevice.Instance().ButtonDown() || Input.GetKeyDown(KeyCode.Space))
        {
            var pos = transform.position;
            pos.y += 0.5f;
            GameObject missile = (GameObject)Instantiate(missilePrefab, pos, transform.rotation);
        }
    }

}
