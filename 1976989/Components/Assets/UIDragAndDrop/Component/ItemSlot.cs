using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    public Text correct;
    public bool correctTile;
    public bool movedTile;


    private void Start()
    {
        correct.enabled = false;

    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("dropped");
        if (eventData.pointerDrag != null && eventData.pointerDrag.tag == ("Blue"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("Blue");
            correct.enabled = true;

            correct.text = "Correct!";
            correctTile = true;
            movedTile = true;
        }
        else if (eventData.pointerDrag != null && eventData.pointerDrag.tag != ("Blue"))
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            correct.enabled = true;
            correct.text = "Incorrect!";
            correctTile = false;
            movedTile = true;
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        correct.enabled = false;
    }

}
