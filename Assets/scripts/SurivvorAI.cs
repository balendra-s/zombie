using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurivvorAI : MonoBehaviour
{



    public GameObject Player;
    public GameObject Survivor;

    public bool isNearPlayer = false;



    void Update()
    {
        if (isNearPlayer == true)
        {
            print("near");
            this.GetComponent<EnemyScript>().enabled = false;
        }
        else
        {
            this.GetComponent<EnemyScript>().enabled = true;
            print("distancen");
            //Survivor.GetComponent<Animation>().Play("Injured walking");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        isNearPlayer = true;
    }

    void OnTriggerExit(Collider other)
    {
        isNearPlayer = false;
    }
}
