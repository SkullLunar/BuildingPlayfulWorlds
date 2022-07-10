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
    cutsceneCam.SetActive(true);
    thePlayer.SetActive(false);

    fire1.SetActive(false);
    Debug.Log("COLLIDED");

}
}
