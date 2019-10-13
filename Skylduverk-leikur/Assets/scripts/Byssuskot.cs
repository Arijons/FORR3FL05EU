using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byssuskot : MonoBehaviour
{ public AudioSource gunsound;  
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            GetComponent<Animation>().Play("Byssuskot");
        }
    }
}
