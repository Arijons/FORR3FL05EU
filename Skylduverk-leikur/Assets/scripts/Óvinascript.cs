using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Óvinascript : MonoBehaviour
{   // Í upphafi er heilsan óvinarins 10 
    public int HeilsaÓvinar = 10;

    // þetta fall  sem minkar heilsu óvinarinns um magnmeiðsla  
    void MinnkaHeilsu(int MagnMeiðsla)
    { 
        HeilsaÓvinar -= MagnMeiðsla;
    }

    private void Update()
    {
        if (HeilsaÓvinar<0)
        {
            Destroy(gameObject);
        }
    }
 
 }







