using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{

    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        loadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }


    public void LoadCredits()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadControls()
    {
        SceneManager.LoadScene(5);
    }
}
