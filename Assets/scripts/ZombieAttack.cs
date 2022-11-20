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
            TheZombieWrapper.GetComponent<EnemyScript>().enabled = false;
            TheZombie.GetComponent<Animation>().Play("Death animation");
            TheZombieWrapper.GetComponent<EnemyScript>().enabled = false;

        }
    }
    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }
}
