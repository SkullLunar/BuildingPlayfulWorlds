using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{   
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject fire4;
    public GameObject fire5;
    public GameObject fire6;
    public GameObject fire7;
    public GameObject fire8;

    void OnTriggerEnter(Collider col)
{   
    //Camera Switch
    cutsceneCam.SetActive(true);
    thePlayer.SetActive(false);

    //Particle system activation
    fire1.SetActive(true);
    fire2.SetActive(true);
    fire3.SetActive(true);
    fire4.SetActive(true);
    fire5.SetActive(true);
    fire6.SetActive(true);
    fire7.SetActive(true);
    fire8.SetActive(true);

    //Debug collission check
    Debug.Log("COLLIDED");
}
}