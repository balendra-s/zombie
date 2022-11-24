using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PistolTrigger : MonoBehaviour
{
    public GameObject HintText;
    public GameObject Trigger;

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
        }
    }

    void OnTriggerExit()
    {
        HintText.SetActive(false);
    }
}
