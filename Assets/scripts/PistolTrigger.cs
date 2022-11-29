using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Enables the fakepistol inside the room in the intro-scene,
// Stops the player for some seconds and displays the hint text.
public class PistolTrigger : MonoBehaviour
{
    public GameObject HintText;
    public GameObject Trigger;
    public GameObject AudioSource;
    public GameObject FakePistol;

    public GameObject ThePlayer;

    void OnTriggerEnter(Collider collider)
    {
        // When the player enter the trigger after
        // picking the pistol, it loads the next level. 
        if (PistolPickUp.isPistolPicked)
        {
            Trigger.SetActive(false);
            SceneManager.LoadScene(3);
        }
        else
        {   // Get a hint text according to the game logic. 
            HintText.SetActive(true);
            AudioSource.SetActive(true);
            ThePlayer.GetComponent<SC_FPSController>().enabled = false;
            StartCoroutine(delay());
            FakePistol.SetActive(true);
        }
    }

    // Deactivates hinttext and audio source when the player exits the trigger. 
    void OnTriggerExit()
    {
        HintText.SetActive(false);
        AudioSource.SetActive(false);
    }

    // Creates a delay to give focus to the hinttext in the canvas. 
    IEnumerator delay()
    {
        yield return new WaitForSeconds(2.5f);
        ThePlayer.GetComponent<SC_FPSController>().enabled = true;

    }
}
