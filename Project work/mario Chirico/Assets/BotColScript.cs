using UnityEngine;
using System.Collections;

public class BotColScript : MonoBehaviour {

   


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Brick" || other.gameObject.tag == "Question" || other.gameObject.tag == "Pipe" || other.gameObject.tag == "Q+") 
        {
            player.Instance.grounded = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Brick" || other.gameObject.tag == "Question" || other.gameObject.tag == "Pipe" || other.gameObject.tag == "Q+")
        {
            player.Instance.grounded = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Brick" || other.gameObject.tag == "Question" || other.gameObject.tag == "Pipe" || other.gameObject.tag == "Q+")
        {
            player.Instance.grounded = false;
        }
    }


}
