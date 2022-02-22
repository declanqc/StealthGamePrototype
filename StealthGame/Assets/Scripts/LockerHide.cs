using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerHide : MonoBehaviour
{
    public GameObject player;
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
            player.transform.position = new Vector3(27.5f, 1f, 5.38000011f);
            InLocker = !InLocker;
        }

        if(NearLocker && InLocker && Input.GetKeyDown("e"))
        {
            player.transform.position = new Vector3(27.5f, 1f, 2.70000005f);
        }
        else if(NearLocker && !InLocker && Input.GetKeyDown("e"))
        {
            player.transform.position = new Vector3(27.5f, 1f, 5.38000011f);
        }
        
    }


}
