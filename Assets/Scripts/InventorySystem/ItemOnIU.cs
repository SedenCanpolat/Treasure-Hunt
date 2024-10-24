using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Holylib.Utilities;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class ItemOnIU : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPos;
    private Canvas canvas;
    private Transform originalParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(canvas.transform, true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = startPos;
        transform.SetParent(originalParent, true);
    }


    /*
        public void OnPointerEnter(PointerEventData pointerEventData)
        {
        Debug.Log("Pointer entered on object");
        }
    */


    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
        originalParent = transform.parent;
        canvas = GameObject.FindObjectOfType<Canvas>();
    }

}
