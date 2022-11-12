using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightScript : MonoBehaviour
{
    public GameObject flashlight_ground, flashlight_player;
    public GameObject extraCursor;
    public GameObject hintText;


    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("MainCamera"))
        {
            hintText.SetActive(true);
            extraCursor.SetActive(true);


            if (Input.GetKeyDown(KeyCode.E))
            {
                flashlight_ground.SetActive(false);
                flashlight_player.SetActive(true);
                extraCursor.SetActive(false);
                hintText.SetActive(false);

            }


        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {

            extraCursor.SetActive(false);
            hintText.SetActive(false);
        }
    }
}