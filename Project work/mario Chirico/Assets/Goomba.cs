using UnityEngine;
using System.Collections;

public class Goomba : MonoBehaviour {
    private Rigidbody rb;

    bool Switch = false;
    int enemyspeed = 1;



    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        if (Switch == false)
        {
            rb.MovePosition(transform.position - transform.right * enemyspeed * Time.fixedDeltaTime);


        }
        if (Switch == true)
        {
            rb.MovePosition(transform.position + transform.right * enemyspeed * Time.fixedDeltaTime);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoombaWall")
        {
            if (Switch == false) { Switch = true; }
            else { Switch = false; }
           

        }

    }
}
