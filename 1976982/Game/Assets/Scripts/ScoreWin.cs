using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreWin : MonoBehaviour
{
    public float Score;
    public Text ScoreT;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        ScoreT.text = ("Score: " + Score);
        if (Score > 10)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    public void AddScore()
    {
        Score++;
    }
}
