using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int currentHealth = 25;
    public int internalHealth;
    public GameObject playerHealth;

    void Update()
    {
        playerHealth.GetComponent<Text>().text = "" + currentHealth;
        internalHealth = currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }




}
