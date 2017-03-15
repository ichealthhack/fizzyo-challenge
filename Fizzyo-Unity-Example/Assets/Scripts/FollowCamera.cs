using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
    public GameObject target;
    Vector3 targetPos;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (target)
        {
            targetPos = target.transform.position;
            targetPos.z = transform.position.z;
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.25f);
        }

    }
}
