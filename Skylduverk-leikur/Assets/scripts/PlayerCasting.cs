using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float DistanceFromTarget;
    public float ToTarget;



    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {   // athuga hvað óvinur margar metra frá byssunni með RaycastHit skipun 
            ToTarget = hit.distance;
            DistanceFromTarget = ToTarget;
        }

    }
}


