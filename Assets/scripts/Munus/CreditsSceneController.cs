using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsSceneController : MonoBehaviour
{

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
