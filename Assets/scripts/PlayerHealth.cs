using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int currentHealth = 20;
    public int internalHealth;

    void Update()
    {
        internalHealth = currentHealth;
        if (currentHealth <= 0)
        {

        }
    }




}
