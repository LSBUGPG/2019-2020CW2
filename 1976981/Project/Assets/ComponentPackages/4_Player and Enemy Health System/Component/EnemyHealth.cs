using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour

{
    public int enemyHealth = 3;
    private EnemyFollow Enemywalk;
    private EnemyShooting EnemyShoot;
    
    // Start is called before the first frame update
    void Start()
    {
        Enemywalk = GetComponent<EnemyFollow>();
        EnemyShoot = GetComponent<EnemyShooting>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {

            Destroy(Enemywalk);
            Destroy(EnemyShoot);
            //gameObject.GetComponent<NavMeshAgent>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlayerBullett")
        {
            enemyHealth -= 1;
            Debug.Log("Hit");
        }
    }
}

