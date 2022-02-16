using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoretext;

    int score = 0;

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


}
