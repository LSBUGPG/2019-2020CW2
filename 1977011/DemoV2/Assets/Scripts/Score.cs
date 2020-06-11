using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Score : MonoBehaviour {
 
    public Text scoreText;
    public int score;
 
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
 
        scoreText.text = "Shots Fired: " + score;
 
        if (Input.GetMouseButtonDown(0))
        {
            score++;
        }
        
        if (score >=4)
        {
            SceneManager.LoadScene(0);
        }
       
    }
}
