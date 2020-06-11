using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public GameObject portal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Portal").Length <= 3)
        {
            float posX = Random.Range(-100f, 100f);
            float posZ = Random.Range(-100f, 100f);
            float posY = Random.Range(-10f, 80f);
            Instantiate(portal, new Vector3(posX, posY, posZ), Quaternion.Euler(0f, 0f, 0f));
        }

    }
}
