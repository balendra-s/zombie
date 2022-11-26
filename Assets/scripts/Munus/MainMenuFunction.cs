using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class MainMenuFunction : MonoBehaviour
{

    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;
    public AudioMixer mainMixer;
    public GameObject newGameButton;
    public GameObject resumeButton;

    // Starts a new game from beginning 
    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    // updates every frame 
    void Update()
    {
        if (PauseMenu.GameIsPaused)
        {
            newGameButton.SetActive(false);
            resumeButton.SetActive(true);
        }

    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        loadText.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    // resume the game 
    public void ResumeGame()
    {
        SceneManager.LoadScene("level1");
    }
    
    // Stops the application
    public void ExitGame()
    {
        Debug.Log("Exited game");
        Application.Quit();
    }

    // Sets the volume via slider in options menu
    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }

}
