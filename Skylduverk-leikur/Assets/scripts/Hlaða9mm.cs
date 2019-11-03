using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hlaða9mm : MonoBehaviour
{
    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int ReloadAvailable;


    // Þetta script hleður 9mm byssuna
    void Update()
    {
        ClipCount = Skotfæri.LoadedAmmo;
        ReserveCount = Skotfæri.CurrentAmmo;

        if (ReserveCount == 0) {
            ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 10 - ClipCount;
        }

        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (ReserveCount <= ReloadAvailable)
                {
                    Skotfæri.LoadedAmmo += ReserveCount;
                    Skotfæri.CurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    Skotfæri.LoadedAmmo += ReloadAvailable;
                    Skotfæri.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }
            }
        }
        StartCoroutine(EnableScripts());

    }
    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        this.GetComponent<Byssuskot>().enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }
    void ActionReload()
    {
        this.GetComponent<Byssuskot>().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent< Animation > ().Play("Hlaða9mm");
    }

}
