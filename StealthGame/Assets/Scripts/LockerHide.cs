using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerHide : MonoBehaviour
{
    public GameObject player;
    public Transform LockerCenter;
    bool NearLocker = false;
    bool InLocker = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            NearLocker = true;
            Debug.Log("nearlocker");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        NearLocker = false;
    }
    private void Update()
    {
        if(NearLocker == true && Input.GetKeyDown("e"))
        {
            player.transform.position = LockerCenter.transform.position;
            InLocker = !InLocker;
        }

        if(NearLocker && InLocker && Input.GetKeyDown("e"))
        {
            player.transform.position = LockerCenter.transform.position;
        }
        else if(NearLocker && !InLocker && Input.GetKeyDown("e"))
        {
            player.transform.position = LockerCenter.transform.position;
        }
        
    }


}
