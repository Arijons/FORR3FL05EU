using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skotfæri : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

  

    // skotfæra er alltaf uppfærður reglulega
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;

    }
}
