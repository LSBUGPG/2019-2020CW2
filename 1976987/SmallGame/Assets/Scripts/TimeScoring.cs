﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScoring : MonoBehaviour
{

    public Text scoreText;

    public float scoreAmount;

    public float pointIncreasedPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
