using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int currentHealth = 50;
    public int internalHealth;
    public GameObject playerHealth;
    public GameObject attackEffect;

    void Update()
    {
        playerHealth.GetComponent<Text>().text = "" + currentHealth;
        internalHealth = currentHealth;
        if (currentHealth <= 0)
        {
            attackEffect.SetActive(false);
            playerHealth.SetActive(false);
            StartCoroutine(ExitGame());
        }
    }

    IEnumerator ExitGame()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
    }




}
