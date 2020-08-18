using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankDestroy : MonoBehaviour
{
    public GameObject Planks;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Ball"))
        {


            Destroy(Planks);

        }
    }


}
