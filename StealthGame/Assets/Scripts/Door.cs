using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Animator door;
    bool NearDoor = false;
    bool DoorOpen = false;
    public Text DoorText;

     void Update()
    {
      



        if (Input.GetKeyDown("e") && NearDoor)

             {
            
            DoorOpen = !DoorOpen;
            DoorText.gameObject.SetActive(false);
            
        
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
            DoorText.gameObject.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            NearDoor = false;
            Debug.Log("notneardoor");
            DoorText.gameObject.SetActive(false);
        }
    }
}
