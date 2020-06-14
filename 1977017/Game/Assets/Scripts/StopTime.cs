using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StopTime : MonoBehaviour
{
    private float fixedDeltaTime;
    public GameObject Win;
    public GameObject Lose;
    // Start is called before the first frame update
    void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Stop")
        {
            Time.timeScale = 0f;
            Debug.Log("Collision");
            Win.SetActive(true);
            Lose.SetActive(false);
        }   
        else if(collision.gameObject.tag == "Void")
        {
           SceneManager.LoadScene(0);  
        }
    }
}
