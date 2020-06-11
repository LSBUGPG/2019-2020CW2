using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{

    public GameObject[] gameSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            for (int i = 0; i < gameSprites.Length; i++)
            {
                gameSprites[i].GetComponent<GameSprite>().Day();
            }

        }
        if (Input.GetMouseButton(1))
        {
            for (int i = 0; i < gameSprites.Length; i++)
            {
                gameSprites[i].GetComponent<GameSprite>().Night();
            }
        }
    }
}
