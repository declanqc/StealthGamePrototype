using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capture : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theTarget;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("gameover");
            ScoreManager.instance.LosePoint();
            thePlayer.transform.position = theTarget.transform.position;
            //SceneManager.LoadScene("James.G.Scene");
        }
    }
}
