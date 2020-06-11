using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    int currentHealth;
    public int numOfHearts;
    public GameObject heartPanel;
     
    public Image fullhearts;
    public Sprite emptyHeart;

    void Start()
    {
        for (int i = 0; i < health; i++)
        {
            Image heart = Instantiate(fullhearts);
            heart.transform.parent = heartPanel.transform;
        }

        currentHealth = health;
    }

    public void TakeDamage()
    {
        Image heart = heartPanel.transform.GetChild(currentHealth -1).GetComponent<Image>();
        heart.sprite = emptyHeart;
        currentHealth -= 1;
        if (currentHealth == 0)
        {
            Destroy(GameObject.FindObjectOfType<PlayerController>().gameObject);

        }
    }
}
