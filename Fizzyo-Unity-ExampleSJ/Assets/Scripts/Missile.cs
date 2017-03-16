using UnityEngine;

public class Missile : MonoBehaviour {

    Vector3 dir = new Vector3(0.1f,0,0);
    int age = 0;
    int lifeSpan = 1000;
	
	// Update is called once per frame
	void Update () {

        var pos = transform.position;
        pos += dir;
        transform.position = pos;

        if(age > lifeSpan)
        {
            Destroy(gameObject);
        }
        age++;
    }
}
