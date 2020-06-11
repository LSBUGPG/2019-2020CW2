using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject spawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.position = new Vector2(spawn.transform.position.x, spawn.transform.position.y);
        }
    }
}
