using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Óvinascript : MonoBehaviour
{
    public int HeilsaÓvinar = 10;

    


    void MinnkaHeilsu(int MagnMeiðsla)
    {
        HeilsaÓvinar = -MagnMeiðsla;
    }

    private void Update()
    {
        if (HeilsaÓvinar<0)
        {
            Destroy(gameObject);
        }
    }
 
 }







