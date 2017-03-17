using UnityEngine;

public class FollowCamera : MonoBehaviour {
    public GameObject target;
    Vector3 targetPos;
	
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
