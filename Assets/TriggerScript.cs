using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{   
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider col)
{   
    cutsceneCam.SetActive(true);
    thePlayer.SetActive(false);
    Debug.Log("COLLIDED");

}
}
