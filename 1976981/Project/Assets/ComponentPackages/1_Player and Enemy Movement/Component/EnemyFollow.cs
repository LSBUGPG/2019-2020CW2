using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public GameObject thePlayer;
    public float detectionDistance = 10f;

    public bool isFollowing;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, thePlayer.transform.position) < detectionDistance)
            isFollowing = true;
        else
            isFollowing = false;

        if (isFollowing)
            gameObject.GetComponent<NavMeshAgent>().SetDestination(thePlayer.transform.position);

    }

}
