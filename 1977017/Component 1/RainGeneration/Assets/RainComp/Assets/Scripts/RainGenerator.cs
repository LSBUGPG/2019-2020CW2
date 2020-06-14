using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGenerator : MonoBehaviour
{

    public Vector3 center;
    public Vector3 size;
    public GameObject RainPrefab;
    GameObject clone;



    // Start is called before the first frame update
    void Start()
    {
        SpawnRain();  
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.Space))
      {
          SpawnRain();
      }  
    }

    public void SpawnRain()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        clone = Instantiate(RainPrefab, pos, Quaternion.identity) as GameObject;
        //Destroy(clone,0.5f);
    }




    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);

    }


}
