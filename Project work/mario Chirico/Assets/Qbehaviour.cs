using UnityEngine;
using System.Collections;

public class Qbehaviour : MonoBehaviour {


    private Vector3 rotation;

    private bool rotating = false;

    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {

        if (rotating == true)
        {
            transform.Rotate(rotation * Random.Range(8,30) *  Time.deltaTime);
        }
    }

    public void Qreact()
    {
        float zz = Random.Range(0, 3);
        float xx = Random.Range(0, 4);
        float yy = Random.Range(0, 2);
        rotation = new Vector3(xx, yy, zz);
        rotating = true;
        SoundManager.Instance.Qalt();
    }

}
