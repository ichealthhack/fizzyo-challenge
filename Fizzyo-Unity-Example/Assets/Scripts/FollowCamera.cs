using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
    public GameObject target;
    Vector3 targetPos;
    public float yHeight = 3;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (target)
        {
            targetPos = target.transform.position;
            targetPos.z = transform.position.z;

            targetPos.y = yHeight;

            transform.position = Vector3.Lerp(transform.position, targetPos, 0.25f);

        }

    }
}
