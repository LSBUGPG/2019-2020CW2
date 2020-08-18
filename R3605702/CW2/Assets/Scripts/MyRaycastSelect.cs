using System.Collections;
using System.ComponentModel;
using UnityEngine;

public class MyRaycastSelect : ItemPickup
{
    Color oldColor;

    public Color selectionColor;
    public GameObject key;
    
    public Item item;

    protected override void OnRaycastEnter(GameObject target)
    {


        



            oldColor = target.GetComponent<Renderer>().material.GetColor("_Color");
            target.GetComponent<Renderer>().material.SetColor("_Color", selectionColor);

            Destroy(key);


            bool wasPickedUp = Inventory.instance.Add(item);

            if (wasPickedUp)
                Destroy(key);

        
       
    }
   
    protected override void OnRaycastLeave(GameObject target)
    {
        target.GetComponent<Renderer>().material.SetColor("_Color", oldColor);
    }
}
