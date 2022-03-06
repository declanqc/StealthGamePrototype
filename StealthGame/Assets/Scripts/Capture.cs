using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Capture : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("gameover");
            ScoreManager.instance.score = 0;
            SceneManager.LoadScene("James.G.Scene");
        }
    }
}
