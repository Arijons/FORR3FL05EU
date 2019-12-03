using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Óvinureltir : MonoBehaviour
{
    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 10;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit skot;

    public int IsAttacking;
    public GameObject ScreenFlash;
    public AudioSource Hurt01;
    public AudioSource Hurt02;
    public AudioSource Hurt03;
    public int PainSound;

    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out skot))
        {
            TargetDistance = skot.distance;
            if (TargetDistance < AllowedRange)// ef player er nálægt óvininum þá gengur óvinurinn að honum
            {
                EnemySpeed = 0.02f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("Walking");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("Idle");
            }
        }

        if (AttackTrigger == 1)// ef óvinur er kominn of nógu nálægt þá ræðst hann á playerinn 
        {
            EnemySpeed = 0;
            if (IsAttacking == 0)
            {
                StartCoroutine(EnemyDamage());
            }
            
            TheEnemy.GetComponent<Animation>().Play("Attacking");
        }

    }
    void OnTriggerEnter() => AttackTrigger = 1;
    void OnTriggerExit() => AttackTrigger = 0;

    IEnumerator EnemyDamage()
    {
        IsAttacking = 1;
        PainSound = Random.Range(1, 4);
        yield return new WaitForSeconds(0.9f);
        ScreenFlash.SetActive(true);
        GlobalHeilsa.PlayerHealth -= 1;
        if (PainSound == 1)
        {
            Hurt01.Play();
        }
        if (PainSound == 2)
        {
            Hurt02.Play();
        }
        if (PainSound == 3)
        {
            Hurt03.Play();
        }
        yield return new WaitForSeconds(0.05f);
        ScreenFlash.SetActive(false);
        yield return new WaitForSeconds(1);
        IsAttacking = 0;

    }
}
     

    

    
