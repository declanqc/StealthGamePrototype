using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollect : MonoBehaviour
{

    public static ItemCollect instance;


    public GameObject item;
    public Text scoretext;

    int score = 0;

    void awake()
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


    private void OnTriggerEnter(Collider other)
    {
        item.gameObject.SetActive(false);
        AddPoint();

        
    }
}
