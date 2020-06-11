using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collect : MonoBehaviour {

	// Use this for initialization
    public string collectorTag;
	public UnityEvent onCollect;
 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == collectorTag)
        {
            onCollect.Invoke();
            Destroy(gameObject);
        }
    }
}
