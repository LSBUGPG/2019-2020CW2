using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHealth = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "EnemyBullett")
        {
            playerHealth -= 1;
            Debug.Log("Hit");
        }
    }
}
