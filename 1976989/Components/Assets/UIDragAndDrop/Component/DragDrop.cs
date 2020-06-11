using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler

{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    [SerializeField] private Canvas canvas;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begindrag");
        canvasGroup.blocksRaycasts = false;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("endDrag");
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
