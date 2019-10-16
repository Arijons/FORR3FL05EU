using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource ammoSound;

    // Þegar leikmaðurinn rekst á skotfærageymsluna þá hækkar magnið á skotfærum um 10 stig og ammo hljóð er spilað
    void OnTriggerEnter (Collider col) 
    {
        ammoSound.Play();
        if (Skotfæri.LoadedAmmo == 0)
        {
            Skotfæri.LoadedAmmo += 10;
            this.gameObject.SetActive(false);

        }
        else
        {

            Skotfæri.CurrentAmmo += 10;
            this.gameObject.SetActive(false);
        }
    }
}
