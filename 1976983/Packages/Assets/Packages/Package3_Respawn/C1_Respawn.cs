using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C1_Respawn : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private int lives;
    public Text lifeCountText;
    public Text loseText;

    private void Start()
    {
        lives = 3;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnPoint.transform.position;

         if (collision.tag == "Player")
         {
            lives = lives - 1;
            SetCountText();
         }
    }

    void SetCountText()
    {
        lifeCountText.text = "Count: " + lives.ToString();


        if (lives == 0)
        {
            loseText.text = "You lose!";
        }
    }


}

