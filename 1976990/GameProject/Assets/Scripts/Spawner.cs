using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timeBetweenSpawns;
    private float timer;

    [SerializeField] private Transform maxX;
    [SerializeField] private Transform minX;
    [SerializeField] private Transform yPos;
    [SerializeField] private Transform maxZ;
    [SerializeField] private Transform minZ;
    [SerializeField] private GameObject missile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenSpawns)
        {
            timer = 0;
            SpawnMissile();
        }
    }

    void SpawnMissile(){
        float xPos = Random.Range(minX.position.x, maxX.position.x);
        float zPos = Random.Range(minZ.position.z, maxZ.position.z);
        Vector3 spawnPosition = new Vector3(xPos, yPos.position.y, zPos);
        Instantiate(missile, spawnPosition, Quaternion.identity);
    }
}
