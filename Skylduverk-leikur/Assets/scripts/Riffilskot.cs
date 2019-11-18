using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riffilskot : MonoBehaviour
{
    public AudioSource gunsound;


    // Þetta fall er updatad í hverjum ramma 
    void Update() { 
   if (Input.GetButtonDown("Fire1"))
    {   // Ef ýtið er á skot þá er hvellurinn spilaður og animation sem lyftir byssuni upp og niður 
        gunsound = GetComponent<AudioSource>();
        gunsound.Play();

    Skotfæri.LoadedAmmo -= 1;
    }
}
}









