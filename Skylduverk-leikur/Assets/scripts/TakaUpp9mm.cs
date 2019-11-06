using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakaUppAK74 : MonoBehaviour
{
    public float TheDistance = PlayerCasting.DistanceFromTarget;
    public GameObject TextDisplay;
    public GameObject FakeGun;
    public GameObject RealGun;
    public GameObject AmmoDisplay;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        if (Input.GetButtonDown("Action"))
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
            TextDisplay.GetComponent<GUIText>().text = "Taka 9mm byssu";
        }
            
    }

    private void OnMousExit()
    {
        TextDisplay.GetComponent<GUIText>().text = "";
    }

    private void TakaUpp9mmByssu ()
    {
        transform.position = new Vector3(0,-1000,0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
    }
}

