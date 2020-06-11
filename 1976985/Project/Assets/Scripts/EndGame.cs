using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{

    public GameObject scoreCount;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (scoreCount.GetComponent<GameManager>().theScore >= 10) {
            SceneManager.LoadScene(1);
        }


    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
