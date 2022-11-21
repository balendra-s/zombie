using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public GameObject TheZombieWrapper;
    public GameObject TheZombie;
    public GameObject ThePlayer;
    public bool attackTrigger;

    // Start is called before the first frame update
    void Update()
    {
        if (attackTrigger == true)
        {
            TheZombie.GetComponent<Animation>().Play("Attack animation");
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
        yield return new WaitForSeconds(3.5f);
        attackTrigger = false;
        TheZombieWrapper.GetComponent<EnemyScript>().enabled = true;
        TheZombie.GetComponent<Animation>().Play("Walking animation");
    }
}
