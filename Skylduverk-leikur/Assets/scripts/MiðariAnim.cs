using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiðariAnim : MonoBehaviour
{
    public GameObject UpCurs;
    public GameObject DownCurs;
    public GameObject LeftCurs;
    public GameObject RightCurs;

    

    // Hér er beðið í 0.1 sekúndu svo dregst miðarinn saman
    IEnumerator Bið()
    {
        yield return new WaitForSeconds(0.1F);
        UpCurs.GetComponent<Animator>().enabled = false;
        DownCurs.GetComponent<Animator>().enabled = false;
        LeftCurs.GetComponent<Animator>().enabled = false;
        RightCurs.GetComponent<Animator>().enabled = false;
    }

    // Hér er checkað hvort það sé búið að skjóta
    void Update()
    {   
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Bið());
            UpCurs.GetComponent<Animator>().enabled = true;
            DownCurs.GetComponent<Animator>().enabled = true;
            LeftCurs.GetComponent<Animator>().enabled = true;
            RightCurs.GetComponent<Animator>().enabled = true;
            Bið();
        }
    }


}



