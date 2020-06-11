using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletscript : MonoBehaviour
{

    public float speed;

    public Transform player;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
       if(col.gameObject.tag == "Player")
      {
            Destroy(gameObject);
       }
        
    }
}
