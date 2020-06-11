using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        
    }


    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, player.position) < stoppingDistance && (Vector3.Distance(transform.position, player.position) > retreatDistance))
        {

        }





    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")



        {



            Destroy(gameObject);

        }
    }
}