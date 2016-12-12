using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public static player Instance;

    public Rigidbody rb;
    private Animator anim;

    private float Jumpforce = 7f;
    
    private float elapsedTime;
    private bool canaccelerate = false;


    private bool moving = false;
    public bool grounded = true;
    public bool belowbrick = false;
    public bool belowQ = false;

    private float speed = 7;

    public GameObject Reveal1;
    public GameObject Reveal2;
    public GameObject Reveal3;
    public GameObject Reveal4;
    



    public GameObject playerstopper;
    


    void Start ()
    {
        Instance = this;
        anim = gameObject.GetComponent<Animator>();
    }



    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.LoadLevel("startscreen");
        }
        if (grounded)
        {
            speed = 7;
        }
        else { speed = 5; }

        anim.SetBool("grounded", grounded);
        anim.SetBool("running", moving);


        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            moving = true;
        }
        else { moving = false; }
    }



    void FixedUpdate()
    {
        Jump();
        move();
    }



    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(0, Jumpforce, 0, ForceMode.Impulse);
            SoundManager.Instance.Jumped();
            grounded = false;
            canaccelerate = true;
        }

        if (canaccelerate && Input.GetKey(KeyCode.Space))
        {
            elapsedTime += Time.deltaTime;
            rb.AddForce(0, 6f, 0, ForceMode.Acceleration);
            if (elapsedTime >= 0.5)
            {
                canaccelerate = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            elapsedTime = 0;
        }
    }



    void move()
    {
        Vector3 direction = (this.transform.right).normalized;

        if (Input.GetKey("a"))
        {
            if (transform.position.x >= playerstopper.transform.position.x)
            { rb.MovePosition(this.transform.position - direction * speed * Time.deltaTime); }
           
        }
     
        if (Input.GetKey("d"))
        {
            rb.MovePosition(this.transform.position + direction * speed * Time.deltaTime);

            if (transform.position.x >= 5 && (transform.position.x - playerstopper.transform.position.x) >= 10)
            {
                playerstopper.transform.position += direction * speed * Time.deltaTime;
            }
            
        }
       
        if (transform.position.y >= 2)
        {
            playerstopper.transform.position = new Vector3(playerstopper.transform.position.x, Mathf.Lerp(2, transform.position.y, 0.3f), playerstopper.transform.position.z);
        }
    }
    


    void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "Portal")
        {
            Application.LoadLevel("endscene");
        }
       if (other.gameObject.name == "shroom1")
        {
            Reveal1.SetActive(true);
            Destroy(other.gameObject);
            SoundManager.Instance.playreveal();
        }
        if (other.gameObject.name == "shroom2")
        {
            Reveal2.SetActive(true);
            Destroy(other.gameObject);
            SoundManager.Instance.playreveal();
        }
        if (other.gameObject.name == "shroom3")
        {
            Reveal3.SetActive(true);
            Destroy(other.gameObject);
            SoundManager.Instance.playreveal();
        }

        if (other.gameObject.name == "shroom4")
        {
            Reveal4.SetActive(true);
            Destroy(other.gameObject);
            SoundManager.Instance.playreveal();
        }

        if (other.gameObject.tag == "DIEDIEDIE")
        {
            Application.LoadLevel("endscene");
        }

    }


    
}
