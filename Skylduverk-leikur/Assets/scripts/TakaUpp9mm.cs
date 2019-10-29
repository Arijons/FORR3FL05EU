using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakaUpp9mm : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject Textdisplay;
    public GameObject FakeGun;
    public GameObject RealGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                TakaUpp9mm();
             
            }
        }
    }
}

