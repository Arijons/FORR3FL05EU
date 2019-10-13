using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byssumeiðsli : MonoBehaviour
{
    public int MagnMeiðsla = 5;
    public float FjarlægðÓvinar;
    public float ByssaDrifur = 15;



    // Start er ekki notað
    void Start()
    {

    }

    // Update fer i gang þegar er ytt á skottakkann
    void Update()
    {   //vinstri smella á mús til að skjóta 
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit Skot;

            {
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Skot))
                {   // athuga hvað óvinur margar metra frá byssunni með RyscastHit skipun 
                    FjarlægðÓvinar = Skot.distance;
                    if (FjarlægðÓvinar < ByssaDrifur)
                    {   // ef byssan er nóg nálægt þá lækkar heilsan hjá óvinum um 5
                        Skot.transform.SendMessage("MinnkaHeilsu", MagnMeiðsla);
                    }
                }
            }
        }
    }
}


           
     


