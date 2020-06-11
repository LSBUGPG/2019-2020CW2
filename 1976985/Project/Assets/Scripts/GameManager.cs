using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int theScore;
    public void Start()
    {
        theScore = 0;
    }

    public void Collect()
    {
        theScore += 1;
        scoreText.text = "Collectables: " + theScore;
    }
}

