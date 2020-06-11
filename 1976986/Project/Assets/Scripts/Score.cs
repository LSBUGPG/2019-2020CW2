using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public int dropscore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "drop")
        {
            dropscore = collision.GetComponent<ItemValue>().value;
            ScoreCall();
            Destroy(collision.gameObject);
        }
    }
    public void ScoreCall()
    {
        score += dropscore;
        scoreText.text = "Score: " + score;  
    }
}
