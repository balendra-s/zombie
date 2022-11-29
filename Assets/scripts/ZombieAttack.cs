using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Activates a attacking animation when the zombies comes
// near the player.
public class ZombieAttack : MonoBehaviour
{
    public GameObject TheZombie;
    public GameObject ThePlayer;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public GameObject attackEffect;

    void Update()
    {
        if (attackTrigger == true && isAttacking == false)
        {
            TheZombie.GetComponent<Animation>().Play("Attack animation");
            StartCoroutine(HurtPlayer());
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
        yield return new WaitForSeconds(1.0f);
        TheZombie.GetComponent<Animation>().Play("Walking animation");
    }

    // Reduces the player health by 5 points, 
    // every time he is attacked and activates attack effect. 
    IEnumerator HurtPlayer()
    {
        isAttacking = true;
        attackEffect.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        PlayerHealth.currentHealth -= 5;
        attackEffect.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        isAttacking = false;

    }
}
