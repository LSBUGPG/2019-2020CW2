using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{


    public void SaveScore(float score)
    {
        PlayerPrefs.SetFloat("HighScore", score);
    }

    public float LoadScore()
    {      
        float score = PlayerPrefs.GetFloat("HighScore");
        return score;
    }

}