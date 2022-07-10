using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{   
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    public AudioSource source;
    public AudioClip clip;

    public GameObject fire;

    void OnTriggerEnter(Collider col)
{   
    //Camera Switch
    cutsceneCam.SetActive(true);
    thePlayer.SetActive(false);

    //play Audio
    source.PlayOneShot(clip);

    //Particle system activation
    fire.SetActive(true);

    //Debug collission check
    Debug.Log("COLLIDED");
}
}