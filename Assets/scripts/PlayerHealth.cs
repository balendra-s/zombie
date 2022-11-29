using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This tracks the health of the player.
public class PlayerHealth : MonoBehaviour
{
    public static int currentHealth = 50;
    public int internalHealth;
    public GameObject playerHealth; // To display the current health of the player in canvas. 
    public GameObject attackEffect; // Gives a red flash when the player gets attacked.

    void Update()
    {
        playerHealth.GetComponent<Text>().text = "" + currentHealth;
        internalHealth = currentHealth;
        // Exits the game when the player health is zero.
        if (currentHealth <= 0)
        {
            attackEffect.SetActive(false);
            playerHealth.SetActive(false);
            StartCoroutine(ExitGame());
        }
    }

    // Loads the main menu, when the player health is zero.
    IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
    }




}
