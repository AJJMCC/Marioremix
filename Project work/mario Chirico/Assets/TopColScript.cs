using UnityEngine;
using System.Collections;

public class TopColScript : MonoBehaviour {

    public GameObject _light;
    private Vector3 LL;
    private float speed = 4;
    private bool Lrotate = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Lrotate)
        {
            _light.transform.rotation = Quaternion.RotateTowards( _light.transform.rotation, Quaternion.Euler(LL.normalized),speed * Time.deltaTime);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Brick")
        {
            other.gameObject.GetComponent<Brickbehaviour>().react();
        }
        if (other.gameObject.tag == "Question")
        {
            other.gameObject.GetComponent<Qbehaviour>().Qreact();
        }
        if (other.gameObject.tag == "Q+")
        {
            other.gameObject.GetComponent<QbehaviourPlus>().Qreact();
        }
        if (other.gameObject.tag == "SS")
        {
            SSReact();
           
            Destroy(other.gameObject);
        }
    }

    void SSReact()
    {
    
        Lrotate = true;
        LL = new Vector3(_light.transform.rotation.z + Random.Range(1,5), _light.transform.rotation.z + Random.Range(1, 5), _light.transform.rotation.z + Random.Range(1, 5));

        
    }
}
