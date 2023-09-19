using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public int ScoreCount = 0;
    void Start()
    {
        ScoreText.text = "Score: " + ScoreCount.ToString();
    }

    public void AddPoint()
    {
        Debug.Log("Girdi");
        ScoreCount++;
        ScoreText.text = "Score: " + ScoreCount.ToString();
    }
   
}
