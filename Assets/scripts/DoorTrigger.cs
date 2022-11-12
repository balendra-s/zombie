using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTrigger : MonoBehaviour
{

    public GameObject ThePlayer;

    public GameObject Trigger;

    public GameObject Trigger1;

    public GameObject Trigger2;

    public AudioSource SoundToPlay;
    public GameObject Door;

    void OnTriggerEnter()
    {
        Door.GetComponent<Animation>().Play("movingDoor");
        ThePlayer.GetComponent<SC_FPSController>().enabled = false;
        //AudioSource.GetComponent<A>().PlayOneShot(SoundToPlay);
        SoundToPlay.Play();
        StartCoroutine(ScenePlayer());

    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(2.5f);

        ThePlayer.GetComponent<SC_FPSController>().enabled = true;
        Trigger.SetActive(false);
        Trigger1.SetActive(false);
        Trigger2.SetActive(false);

    }

}
