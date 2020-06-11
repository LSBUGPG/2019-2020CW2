using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C1_Collectable : MonoBehaviour
{

    public int coins = 0;
    public int winScore = 3;

    public Text countText;
    public Text winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coins += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + coins.ToString();


        if (coins >= winScore)
        {
            winText.text = "You win!";
        }
    }
}

