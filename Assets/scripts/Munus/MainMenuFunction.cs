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


    public void LoadCreditsButton()
    {
        StartCoroutine(LoadCredits());
    }

    IEnumerator LoadCredits()
    {
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene(4);
        buttonClick.Play();
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }

    public void ReturnToMainMenu()
    {
        buttonClick.Play();
        SceneManager.LoadScene(0);

    }
}
