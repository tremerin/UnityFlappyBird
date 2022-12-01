using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score;
    public Text scoreText;

    void Start()
    {
        score = 0;    
    }


    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + score.ToString("0");
    }
}
