using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    public int Score = 0;
    public GameObject ScoreText;
    private float Rate = 3f;
    private float ToNext = 0f;
    void Start()
    {
        
    }


    void Update()
    {
        if(Time.time >= ToNext)
        {
            Score += 1;
            ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
            ToNext = Time.time + 1f / Rate;
        }
    }

}
