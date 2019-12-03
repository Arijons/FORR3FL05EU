using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHeilsa : MonoBehaviour

{

    public static int PlayerHealth = 5;
    public int InternalHealth;
    public GameObject HeilsuMiði;

    void Update() // ef heilsan er == 0 er farið beint í game over senuna

    {
        InternalHealth = PlayerHealth;
        HeilsuMiði.GetComponent<Text>().text = "Heilsa: " + PlayerHealth;
        if (PlayerHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}



