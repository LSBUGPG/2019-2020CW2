using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    private void OnTriggerEnter(Collider other)
    {
        gm.GetComponent<GameManager>().Collect();
        Destroy(gameObject);
    }
}
