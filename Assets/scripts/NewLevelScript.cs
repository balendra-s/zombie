using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NextLevelTrigger;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
}
