using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public GameObject TheZombieWrapper;
    public GameObject TheZombie;
    public GameObject ThePlayer;
    public bool attackTrigger = false;
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Update()
    {
        if (attackTrigger == true && isAttacking == false)

        {
            TheZombie.GetComponent<Animation>().Play("Attack animation");
            StartCoroutine(HurtPlayer());
            TheZombieWrapper.GetComponent<EnemyScript>().enabled = false;
        }
    }
    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        attackTrigger = false;
        yield return new WaitForSeconds(3.5f);
        TheZombieWrapper.GetComponent<EnemyScript>().enabled = true;
        TheZombie.GetComponent<Animation>().Play("Walking animation");
    }

    IEnumerator HurtPlayer()
    {
        print(PlayerHealth.currentHealth);
        // if (PlayerHealth.currentHealth <= 0)
        // {
        //     print("DEAD");
        //     ThePlayer.GetComponent<FirePistol>().enabled = false;
        // }
        isAttacking = true;
        yield return new WaitForSeconds(1.1f);
        PlayerHealth.currentHealth -= 5;
        yield return new WaitForSeconds(0.2f);
        isAttacking = false;

    }
}
