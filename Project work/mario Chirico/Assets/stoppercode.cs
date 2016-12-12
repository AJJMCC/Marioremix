using UnityEngine;
using System.Collections;

public class stoppercode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("stopper hit player");
            //current position
            float py = other.gameObject.transform.position.y;
            float pz = other.gameObject.transform.position.z;

            //place at new position
            other.gameObject.transform.position = new Vector3(transform.position.x + 1f, py, pz);
            Debug.Log("stopper moved player");
        }

    }
}
