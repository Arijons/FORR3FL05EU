using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakauppAK47 : MonoBehaviour

{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;
    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject AmmoDisplay;

 

    // Í þessu scripti er riffillinn tekin upp þegar ýtt er á E
    private void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("taka upp riffil"))
        {
            if (TheDistance <= 2)
            {
                TakaUpp9mmByssu();
            }
        }
    }

    private void OnMousOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<GUIText>().text = "Taka AK74";
        }

    }

    private void OnMousExit()
    {
        TextDisplay.GetComponent<GUIText>().text = "";
    }

    private void TakaUpp9mmByssu()
    {
        transform.position = new Vector3(0, -1000, 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
    }
}



