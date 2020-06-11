using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject VictoryPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            VictoryPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
