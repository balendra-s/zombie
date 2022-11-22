using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorZombieAttack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject TheSurvivorWrapper;
    public GameObject TheSurvivor;
    public GameObject Trigger;

    public GameObject ZombieWrapper;
    public GameObject ZombieWrapper1;



    void OnTriggerEnter(Collider collider)
    {
        Trigger.GetComponent<BoxCollider>().enabled = false;
        TheSurvivorWrapper.GetComponent<EnemyScript>().enabled = true;
        TheSurvivor.GetComponent<Animation>().Stop("Idle animation");
        TheSurvivor.GetComponent<Animation>().Play("Injured walking");

        ZombieWrapper.GetComponent<EnemyScript>().enabled = true;
        ZombieWrapper1.GetComponent<EnemyScript>().enabled = true;
        ZombieWrapper.GetComponent<BoxCollider>().enabled = true;
        ZombieWrapper1.GetComponent<BoxCollider>().enabled = true;
        TheSurvivorWrapper.GetComponent<SurivvorAI>().enabled = true;

        Trigger.SetActive(false);

    }
}
