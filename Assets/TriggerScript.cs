using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    //Particle system activation
    fire.SetActive(true);

    //Debug collission check
    Debug.Log("COLLIDED");

    StartCoroutine(TimeDelay());
}

IEnumerator TimeDelay()
{
yield return new WaitForSeconds(5);
 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
}

}