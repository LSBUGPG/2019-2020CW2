using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Complete : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            GameObject.Find("GameComplete").GetComponent<Text>().text = "Game Complete";
        }
    }
}
