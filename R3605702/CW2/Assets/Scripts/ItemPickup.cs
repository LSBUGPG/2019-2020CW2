﻿using UnityEngine;

public class ItemPickup : MonoBehaviour 
{

    public float selectionDistance = 1f;
    public LayerMask layerMask;

    private GameObject currentTarget;

    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, selectionDistance, layerMask))
        {
            if(currentTarget == null)
            {
                currentTarget = hit.transform.gameObject;
                OnRaycastEnter(currentTarget);

            }

            else if(currentTarget != hit.transform.gameObject)
            {
                OnRaycastLeave(currentTarget);
                currentTarget = hit.transform.gameObject;
                OnRaycastEnter(currentTarget);
            }
            OnRaycast(hit.transform.gameObject);
        }

        else if (currentTarget != null)
        {
            OnRaycastLeave(currentTarget);
            currentTarget = null;
        }
    }

    protected virtual void OnRaycastEnter(GameObject target)
    {

    }
    protected virtual void OnRaycastLeave(GameObject target)
    {

    }
    protected virtual void OnRaycast(GameObject target)
    {

    }
}
