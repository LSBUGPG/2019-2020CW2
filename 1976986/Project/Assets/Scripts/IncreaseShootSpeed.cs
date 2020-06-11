using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseShootSpeed : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Shooting>().StartCoroutine("IncreaseShootSpeed");
            Destroy(gameObject);
        }
    }
}
