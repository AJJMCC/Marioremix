using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public static SoundManager Instance;
    public AudioSource SFX;
    public AudioClip jump;
    public AudioClip hitbrick;
    public AudioClip hitQ;
    public AudioClip reveal;

    void Start ()
    {
        Instance = this;
	}
	


	void Update ()
    {
	
	}
    public void Jumped()
    {
        SFX.PlayOneShot(jump);
    }

    public void bricksmash()
    {
        SFX.PlayOneShot(hitbrick);
    }
    public void Qalt()
    {
        SFX.PlayOneShot(hitQ);
    }
    public void playreveal()
    {
        SFX.PlayOneShot(reveal);
    }
}
