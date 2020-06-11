using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullett;
    public Transform bullettspawn;
    private EnemyFollow enemyFollowScript;
    private bool isShooting;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Shoot", 3f);
        enemyFollowScript = GetComponent<EnemyFollow>();

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyFollowScript.isFollowing && !isShooting)
        {
            InvokeRepeating("Shoot", 3f, 3f);
            isShooting = true;
        }
        else if(!enemyFollowScript.isFollowing && isShooting)
        {
            StopShoot();
        }
    }

    private void Shoot()
    {
        Invoke("Shootagain", 2f);
        Instantiate(bullett, bullettspawn.position, Quaternion.identity);
    }
    private void StopShoot()
    {
       CancelInvoke();
       isShooting = false;
    }
}
