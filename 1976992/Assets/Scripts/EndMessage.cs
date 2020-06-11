using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMessage : MonoBehaviour
{

    public TextMeshProUGUI endText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        endText.enabled = true;
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds (3);
        SceneManager.LoadScene("1");
    }
}
