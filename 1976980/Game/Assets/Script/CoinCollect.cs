using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);


            Text TotalCoins = GameObject.Find("TotalCoins").GetComponent<Text>();

            int currentTotal = int.Parse(TotalCoins.text.Split(':')[1]) + 1;

            TotalCoins.text = "Coins: " + currentTotal;

        }
    }
}