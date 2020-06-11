using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject[] currentBlocks;
    public GameObject[] layerOne;
    public GameObject[] layerTwo;
    public GameObject[] layerThree;
    public GameObject[] layerFour;
    public GameObject gridPointAvailable;

    private int nextLayerToActivate = 2;

    private GameObject[] nextLayer;

    void Start()
    {
        //GenerateGrid();
        nextLayer = new GameObject[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateGrid()
    {
        foreach (GameObject block in currentBlocks)
        {
            for(int i = 0; i < 4; i++)
            {
                Vector3 directionRay = Vector3.zero;
                switch(i)
                {
                    case 0:
                        directionRay = block.transform.forward;
                        break;
                    case 1:
                        directionRay = -block.transform.forward;
                        break;
                    case 2:
                        directionRay = block.transform.right;
                        break;
                    case 3:
                        directionRay = -block.transform.right;
                        break;
                }
                    
                RaycastHit hit;
                if (!Physics.Raycast(block.transform.position, directionRay, out hit, 1f)) //If There is space available
                {
                    Instantiate(gridPointAvailable, block.transform.position + directionRay, Quaternion.identity);
                    
                }
            }
        }
    }

    public void GenerateNextLayer()
    {
        if (nextLayerToActivate < 5)
        {
            IdentifyNextLayer();
            for(int i = 0; i < nextLayer.Length; i++)
            {
                Instantiate(gridPointAvailable, nextLayer[i].transform.position, Quaternion.identity);
                Destroy(nextLayer[i].gameObject);
            }
        }
        else
        {
            Debug.Log("No More Layers Available");
        }
    }

    private void IdentifyNextLayer()
    {
        switch (nextLayerToActivate)
        {
            case 2:
                FillArray(layerTwo);
                nextLayerToActivate++;
                break;
            case 3:
                FillArray(layerThree);
                nextLayerToActivate++;
                break;
            case 4:
                FillArray(layerFour);
                nextLayerToActivate++;
                break;
            default:
                break;

        }
    }

    private void FillArray(GameObject[] objects)
    {
        Array.Clear(nextLayer, 0, nextLayer.Length);
        nextLayer = new GameObject[objects.Length];
        for(int i = 0; i < objects.Length; i++)
        {
            nextLayer[i] = objects[i];
        }
    }
}