using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeModel : MonoBehaviour
{
    public GameObject[] interchangeableModels;
    public GameObject baseObject;

    private  int indexToSpawn = 0;
    private bool setOriginal = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
    
            if(Physics.Raycast (ray, out hit))
            {
                if(hit.transform.tag == "Parent")
                {
                    if (setOriginal)
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(true);
                        if (hit.transform.childCount > 1) //We already have a spawned model
                        {
                            Destroy(hit.transform.GetChild(1).gameObject);
                        }
                    }
        
                    else
                    {
                        hit.transform.GetChild(0).gameObject.SetActive(false);
                        if (hit.transform.childCount > 1) //We already have a spawned model
                        {
                            Destroy(hit.transform.GetChild(1).gameObject);
                        }
                        GameObject newSpawn = Instantiate(interchangeableModels[indexToSpawn], hit.transform.position, Quaternion.identity);
                        newSpawn.transform.parent = hit.transform;
                    }
                }
                else if(hit.transform.tag == "RedCircle")
                {
                    Debug.Log("Not Available Yet");
                }
                else if (hit.transform.tag == "GreenCircle")
                {
                    //InstantiateNewBlock
                    Instantiate (baseObject, hit.transform.position, Quaternion.identity);
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    public void SetIndex(int index)
    {
        indexToSpawn = index;
        setOriginal = false;
    }

    public void SetToOriginal()
    {
        setOriginal = true;
    }
}