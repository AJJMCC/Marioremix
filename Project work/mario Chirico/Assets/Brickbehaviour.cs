using UnityEngine;
using System.Collections;

public class Brickbehaviour : MonoBehaviour {
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void react()
    {
       rb.isKinematic = false;
        rb.AddForce(new Vector3(0, 3, 0.9f), ForceMode.Impulse);
        SoundManager.Instance.bricksmash();
    }
}
