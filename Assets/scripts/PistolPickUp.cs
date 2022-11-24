using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickUp
 : MonoBehaviour
{
    //public GameObject Inticon;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject ExtraCursor;
    public GameObject HintText;


    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Camera"))
        {

            HintText.SetActive(true);
            ExtraCursor.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                ExtraCursor.SetActive(false);
                HintText.SetActive(false);

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Camera"))
        {
            ExtraCursor.SetActive(false);
            HintText.SetActive(false);
        }
    }
}