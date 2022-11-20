using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;

    public GameObject MuzzleFlash;
    public AudioSource GunFire;
    public bool IsFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;
    Ray ray;

    // Update is called once per frame
    void Update()
    {

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Input.GetButtonDown("Fire1"))
        {
            if (IsFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {

        RaycastHit Shot;
        IsFiring = true;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            print(Shot.transform.name);
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);


        }
        TheGun.GetComponent<Animation>().Play("PistolShot");
        MuzzleFlash.SetActive(true);
        MuzzleFlash.GetComponent<Animation>().Play("MuzzleAnimation");

        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        IsFiring = false;
    }
}
