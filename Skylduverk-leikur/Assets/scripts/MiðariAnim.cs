using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiðariAnim : MonoBehaviour
{
    public GameObject UpCurs;
    public GameObject DownCurs;
    public GameObject LeftCurs;
    public GameObject RightCurs;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            UpCurs.GetComponent<Animator>().enabled = true;
            DownCurs.GetComponent<Animator>().enabled = true;
            LeftCurs.GetComponent<Animator>().enabled = true;
            RightCurs.GetComponent<Animator>().enabled = true;
            WA();

        }
    }
     void WA()
    {   
        UpCurs.GetComponent<Animator>().enabled = false;
        DownCurs.GetComponent<Animator>().enabled = false;
        LeftCurs.GetComponent<Animator>().enabled = false;
        RightCurs.GetComponent<Animator>().enabled = false;

    }
}



