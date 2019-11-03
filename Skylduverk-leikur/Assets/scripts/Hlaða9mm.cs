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

        if (ReserveCount == 0 ) {
        }




    }
}
/*
 * //Jimmy Vegas Unity 5 Tutorial
//This script will reload your handgun


function Update () {


	if (ReserveCount == 0) {
		ReloadAvailable = 0;
	}
	else {
		ReloadAvailable = 10 - ClipCount;
	}

	if(Input.GetButtonDown("Reload")) {
		if (ReloadAvailable >= 1) {
			if (ReserveCount <= ReloadAvailable) {
				GlobalAmmo.LoadedAmmo += ReserveCount;
				GlobalAmmo.CurrentAmmo -= ReserveCount;
				ActionReload();
			}
			else {
				GlobalAmmo.LoadedAmmo += ReloadAvailable;
				GlobalAmmo.CurrentAmmo -= ReloadAvailable;
				ActionReload();
			}
		}
	EnableScripts();

	}
}

function EnableScripts () {
	yield WaitForSeconds (1.1);
			this.GetComponent("GunFire").enabled=true;
			CrossObject.SetActive(true);
			MechanicsObject.SetActive(true);
}

function ActionReload () {
	this.GetComponent("GunFire").enabled=false;
	CrossObject.SetActive(false);
	MechanicsObject.SetActive(false);
	ReloadSound.Play();
	GetComponent.<Animation>().Play("HandgunReload");
}
*/