using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Óvinahreyfing : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 10;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int MoveTrigger;
    //public RaycastHit Shot;

    void Update()
    {
        // transform.LookAt(ThePlayer.transform);
        if (MoveTrigger == 1)
        {
            EnemySpeed = 0.02f;
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }
    }
}
       