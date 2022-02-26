using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door;
    bool NearDoor = false;
    bool DoorOpen = false;

     void Update()
    {
       
        if (Input.GetKeyDown("e") && NearDoor)

             {
            
            DoorOpen = !DoorOpen;
        
             }

        if(DoorOpen)
        {
            door.SetBool("NearDoor", true);
            
        }
        else if(!DoorOpen)
        {
            door.SetBool("NearDoor", false);
        }
        
  

  
    }
    private void OnTriggerEnter(Collider other)
    {

        

        if(other.gameObject.CompareTag("Player"))
        {
            NearDoor = true;            
            Debug.Log("neardoor");
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            NearDoor = false;
            Debug.Log("notneardoor");
        }
    }
}
