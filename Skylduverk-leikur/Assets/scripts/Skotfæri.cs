using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skotfæri : MonoBehaviour
{
    public static int CurrentAmmo;
    public int InternalAmmo;
    public GameObject AmmoDisplay;

    public static int LoadedAmmo;
    public int InternalLoaded;
    public GameObject LoadedDisplay;

    // skotfæra er alltaf uppfærður reglulega
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        InternalLoaded = LoadedAmmo;
        LoadedDisplay.GetComponent<Text>().text = "" + LoadedAmmo;
        AmmoDisplay.GetComponent<Text>().text = "" + InternalAmmo;

    }
}
