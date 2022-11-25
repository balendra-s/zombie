using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroductionSequencing : MonoBehaviour
{

    

    public GameObject textBox;
    public GameObject placeDisplay;
    public AudioSource thudSound;
    public GameObject allBlack;
    public GameObject loadText;
    public GameObject skipIntroText;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SequenceBegin());
    }

    // this function is called for every fram 
    void Update()
    {
        // skips the introduction animation if the enter/return key is pressed 
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(2);
        }
    }

    // to display text in textbox under introduction animation 
    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(3);
        skipIntroText.SetActive(true);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "This is the night that changed my life forever...";
        yield return new WaitForSeconds(4.5f);
        textBox.GetComponent<Text>().text = "";
        textBox.GetComponent<Text>().text = "I headed out to investigate the haunting sounds in the woods.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        textBox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance";;
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "I could hear those sounds again coming from there.";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Little did I know that this was only the beginning.";
        yield return new WaitForSeconds(2);
        allBlack.SetActive(true);
        textBox.GetComponent<Text>().text = "*knocked out*";
        thudSound.Play();
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

   
}
