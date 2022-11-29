using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This loads the next level, when the player enters the trigger. 
public class NewLevelScript : MonoBehaviour
{

    public GameObject NextLevelTrigger;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
