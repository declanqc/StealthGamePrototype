using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public Animator door2;
    bool NearDoor2 = false;
    bool DoorOpen2 = false;

    void Update()
    {

        if (Input.GetKeyDown("e") && NearDoor2)

        {

            DoorOpen2 = !DoorOpen2;

        }

        if (DoorOpen2)
        {
            door2.SetBool("NearDoor2", true);

        }
        else if (!DoorOpen2)
        {
            door2.SetBool("NearDoor2", false);
        }




    }
    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.CompareTag("Player"))
        {
            NearDoor2 = true;
            Debug.Log("neardoor2");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NearDoor2 = false;
            Debug.Log("notneardoor2");
        }
    }
}
