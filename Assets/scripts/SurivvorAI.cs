using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurivvorAI : MonoBehaviour
{

    public GameObject Player;
    public GameObject Survivor;

    public bool isNearPlayer = false;
    public bool isIdle = false;



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
