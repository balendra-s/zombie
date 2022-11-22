using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroductionSequencing : MonoBehaviour
{

    public GameObject textBox;
    public GameObject placeDisplay;
    public AudioSource line01;
    public AudioSource line02;
    public AudioSource line03;
    public AudioSource line04;
    public AudioSource line05;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SequenceBegin());
    }


    IEnumerator SequenceBegin()
    {
        yield return new WaitForSeconds(3);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "This is the night that changed my life forever...";
        line01.Play();
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        textBox.GetComponent<Text>().text = "I headed out to investigate the haunting sounds in the woods.";
        line02.Play();
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "";
        textBox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance";
        line03.Play();



    }

   
}
