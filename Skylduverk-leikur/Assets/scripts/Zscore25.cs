using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// þegar skýtur óvininn þá fær 10 stig fyrir hvert skot 
public class Zscore25 : MonoBehaviour
{
    private void MinnkaHeilsu(int MagnMeiðsla)
    {
        GlobalStig.CurrentScore += 10;
    }
}