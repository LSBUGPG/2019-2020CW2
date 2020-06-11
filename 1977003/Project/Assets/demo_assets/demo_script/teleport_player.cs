using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport_player : MonoBehaviour
{
    public GameObject targetPoint;
    public wormhole_summon portalCheck;

    void Start()
    {
        targetPoint = GameObject.FindWithTag("endpoint");
        portalCheck = GameObject.FindWithTag("Player").GetComponentInChildren<wormhole_summon>();
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Portal hit!");
        if(other.tag == "Player") {

            other.transform.position = targetPoint.transform.position + targetPoint.transform.forward * 1;

            portalCheck.portalIsActive = false;
            portalCheck.wormhole_alter = !portalCheck.wormhole_alter;

            Destroy(transform.parent.gameObject);
            Destroy(targetPoint);
        }
    }
}
