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
    public GameObject Cursor;
    public GameObject HintText;

    public static bool isPistolPicked;


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
                Cursor.SetActive(true);
                isPistolPicked = true;

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