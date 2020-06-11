using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustGenerator : MonoBehaviour
{
    Rigidbody rb;
    bool isMoving;
    public GameObject dustParticle;
    GameObject spawnPos;

    public float timeBetweenParticles = 1f;
    private float timeElapsed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPos = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        isMoving = IsMoving();
        if(isMoving && timeElapsed >= timeBetweenParticles){
            timeElapsed = 0;
            SpawnDust();
        }
    }

    bool IsMoving(){
        return(rb.velocity.x > 0) || (rb.velocity.z > 0);
    }

    void SpawnDust(){
        
        spawnPos.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        spawnPos.transform.eulerAngles = this.transform.eulerAngles;
        Instantiate(dustParticle, spawnPos.transform);
    }
}
