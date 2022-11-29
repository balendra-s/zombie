using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To make the survivor to follow the player. 
// The survivor goes to idle animation when he is near the player, 
// and goes to injured walking animation when distance is increased 
// between the player and the survivor.
public class SurivvorAI : MonoBehaviour
{

    public GameObject Player;
    public GameObject Survivor;

    public bool isNearPlayer = false;
    public bool isIdle = false;

    // Checks whether the survivor is near the player and 
    // activates animations according to the result.
    void Update()
    {
        if (isNearPlayer == true && isIdle == false)
        {
            this.GetComponent<EnemyScript>().enabled = false;
            this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            Survivor.GetComponent<Animation>().Play("Idle animation");
            StartCoroutine(moveSurvivor());
        }
    }

    // Set to true when the survivor is near the player.
    void OnTriggerEnter()
    {
        isNearPlayer = true;
    }

    void OnTriggerExit()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        isNearPlayer = false;
        yield return new WaitForSeconds(2.0f);
        this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
        this.GetComponent<EnemyScript>().enabled = true;
        Survivor.GetComponent<Animation>().Play("Injured walking");
    }
    IEnumerator moveSurvivor()
    {
        isNearPlayer = true;
        yield return new WaitForSeconds(1.0f);
        isNearPlayer = false;

    }
}
