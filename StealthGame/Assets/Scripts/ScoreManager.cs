using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoretext;
    public GameObject winText;

    public int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoretext.text = score.ToString();
    }

    public void AddPoint()
    {
        score += 500;
        scoretext.text = score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (ScoreManager.instance.score == 2000 && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Success!");
            winText.gameObject.SetActive(true);
        }
        else if(ScoreManager.instance.score < 2000 && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Keep going!");
        }
    }
    
}
