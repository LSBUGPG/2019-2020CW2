using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayer : MonoBehaviour {

    public Player player;
    public Text healthText;
    public Text experienceText;
    public Text goldText;
	
	// Update is called once per frame
	void Update () {
        healthText.text = player.health.ToString();
        experienceText.text = player.experience.ToString();
        goldText.text = player.gold.ToString();
	}
}
