using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byssuskot : MonoBehaviour
{ public AudioSource gunsound;
  public GameObject Flash;

 


    // Þetta fall er updatad í hverjum ramma 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {   // Ef ýtið er á skot þá er hvellurinn spilaður og animation sem lyftar byssuni upp og niður 
            gunsound = GetComponent<AudioSource>();
            gunsound.Play();
            this.Flash.SetActive(true);
            StartCoroutine(Flashoff());
            Flashoff();
            GetComponent<Animation>().Play("Byssuskot");
            Skotfæri.LoadedAmmo -= 1;
        }
    }

    
    IEnumerator Flashoff()
    {
        yield return new WaitForSeconds(0.1F);
        this.Flash.SetActive(false);
    }


}


