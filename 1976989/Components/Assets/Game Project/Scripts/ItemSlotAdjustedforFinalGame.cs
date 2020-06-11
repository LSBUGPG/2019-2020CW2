using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotAdjustedforFinalGame : MonoBehaviour, IDropHandler
{

    public Text correct;
    public bool correctTile;
    public bool movedTile;

    // parameters below are for final game

    public GameObject platform1;
    public GameObject platform2;
   public GameObject draggedPlatform1;
   public GameObject draggedPlatform2;
    public bool correctTile1;
    public bool correctTile2;



    public void Start()
    {
        correct.enabled = false;
        //code below for final game
        platform1.SetActive(false);
        platform2.SetActive(false);
    
    }
 
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("dropped");
        // code below here is specifically for my final game - I have adjusted the tag required for certain things to happen, and also the thing which happens.
        if (eventData.pointerDrag != null && eventData.pointerDrag.tag == ("Platform1"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("Platform1");
            platform1.SetActive(true);
            draggedPlatform1.SetActive(false);
            movedTile = true;
            correctTile1 = true;

        }
     
        if (eventData.pointerDrag != null && eventData.pointerDrag.tag == ("Platform2"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("Platform2");
            platform2.SetActive(true);
            draggedPlatform2.SetActive(false);
            correctTile2 = true;

        }
       

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        correct.enabled = false;
    }

}
