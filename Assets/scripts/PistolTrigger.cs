using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PistolTrigger : MonoBehaviour
{
    public GameObject HintText;
    public GameObject Trigger;
    public GameObject AudioSource;
    public GameObject FakePistol;

    public GameObject ThePlayer;

    void OnTriggerEnter(Collider collider)
    {
        if (PistolPickUp.isPistolPicked)
        {
            Trigger.SetActive(false);
            SceneManager.LoadScene(3);
        }
        else
        {
            HintText.SetActive(true);
            AudioSource.SetActive(true);
            ThePlayer.GetComponent<SC_FPSController>().enabled = false;
            StartCoroutine(delay());
            FakePistol.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        HintText.SetActive(false);
        AudioSource.SetActive(false);
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(2.5f);
        ThePlayer.GetComponent<SC_FPSController>().enabled = true;

    }
}
