using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ItemOnIU : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 startPos;
    private Transform originalParent;
    public GameObject slot;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = this.transform.position;
        transform.SetParent(transform.parent.parent);
        Debug.Log("Canvas");

    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = startPos;
        transform.SetParent(originalParent, true);
        //Destroy(this.gameObject);
        //if(this.gameObject.GetComponent<Image>().sprite == )
        Debug.Log("Original");
    }

    
    void Start()
    {   
        originalParent = transform.parent;
    }
   

}
