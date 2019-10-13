using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byssumeiðsli : MonoBehaviour
{
    public int MagnMeiðsla = 5;
    public float FjarlægðÓvinar;
    public float BysssaDrifur = 15;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit Skot;

            {
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Skot))
                {
                    FjarlægðÓvinar = Skot.distance;
                    if (FjarlægðÓvinar < BysssaDrifur)
                    {
                        Skot.transform.SendMessage("MinnkaHeilsu", MagnMeiðsla);
                    }
                }
            }
        }
    }
}


           
     


