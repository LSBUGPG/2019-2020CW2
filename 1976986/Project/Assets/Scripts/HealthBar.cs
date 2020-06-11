using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Slider HPslider;
    private int maxhp;
    private int currenthp;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        HPslider = gameObject.GetComponent<Slider>();
        maxhp = player.GetComponent<PlayerController>().maxHealth;
        HPslider.maxValue = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            HPslider.value = 0;
        }
        currenthp = player.GetComponent<PlayerController>().currentHealth;
        HPslider.value = currenthp;

    }
}
