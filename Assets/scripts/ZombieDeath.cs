using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public int EnemyHealth = 10;
    public GameObject TheEnemy;
    public GameObject TheEnemyWrapper;
    public int StatusCheck;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("Walking animation");


            TheEnemy.GetComponent<Animation>().Play("Death animation");


            TheEnemy.GetComponent<Animation>().Stop("Zombie Crawl");
            TheEnemyWrapper.GetComponent<EnemyScript>().enabled = false;

        }

    }
}
