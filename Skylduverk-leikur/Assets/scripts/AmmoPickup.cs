using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{


    // Þegar leikmaðurinn rekstá skotfærageymsluna þá hækkar magnið á skotfærum um 10 stig
    void OnTriggerEnter (Collider col) 
    {
        Skotfæri.CurrentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}
