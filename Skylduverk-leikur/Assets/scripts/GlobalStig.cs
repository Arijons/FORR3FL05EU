using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// her er haldið utan um stigagjöfina 
public class GlobalStig : MonoBehaviour
{
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreTexti;


    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        ScoreTexti.GetComponent<Text >().text = "" + InternalScore;

    }
 
}



