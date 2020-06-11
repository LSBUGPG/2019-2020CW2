using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    public GameObject[] characters;
    int charactersIndex;
    GameObject currentCharacter;

    // Start is called before the first frame update
    void Start()
    {
        charactersIndex = 0;
        currentCharacter = characters[0];
        characters[0].GetComponent<characterMovement>().enabled = true;
        characters[1].GetComponent<characterMovement>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            charactersIndex++;
            if (charactersIndex == characters.Length)
            {
                charactersIndex = 0;

            }
            currentCharacter.GetComponent<characterMovement>().enabled = false;
            characters[charactersIndex].GetComponent<characterMovement>().enabled = true;

       

          
            currentCharacter = characters[charactersIndex];



        }
    }
}
