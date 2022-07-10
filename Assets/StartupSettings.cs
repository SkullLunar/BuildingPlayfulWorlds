using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupSettings : MonoBehaviour
{
    public GameObject flame;
    // Start is called before the first frame update    
    void Start()
    {
    flame.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {

    }
}
