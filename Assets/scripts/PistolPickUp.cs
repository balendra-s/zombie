using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enables the real pistol attached to the player, 
// when the fake pistol is picked from the floor. 
// The fake pistol will be disabled when it is picked. 
public class PistolPickUp
 : MonoBehaviour
{

    public GameObject FakePistol; // Pistol to be picked from the floor. 
    public GameObject RealPistol; // Pistol attached to the player.
    public GameObject ExtraCursor; // Enabled when the player is on the trigger.
    public GameObject Cursor;
    public GameObject HintText; // Text to the player as guidance. 

    public static bool isPistolPicked;

    // When the camera box collider comes in contact
    // with the fakepistol with the tag "camera"
    void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Camera"))
        {

            HintText.SetActive(true);
            ExtraCursor.SetActive(true);
            // When E is pressed, activates the following objects.
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

    // When the camera box collider comes out of the contact area. 
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Camera"))
        {
            ExtraCursor.SetActive(false);
            HintText.SetActive(false);
        }
    }
}