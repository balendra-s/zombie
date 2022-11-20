using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public GameObject TheZombie;
    public GameObject Trigger;
    // Start is called before the first frame update
    void onTriggerEnter()
    {
        TheZombie.GetComponent<Animation>().Play("Death animation");
    }

    // Update is called once per frame

}
