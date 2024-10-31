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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if(hit.collider.gameObject == InventoryManager.instance.rightPlaceInDictionary(this.GetComponent<Slot>().item)){
            Debug.Log(InventoryManager.instance.rightPlaceInDictionary(this.GetComponent<Slot>().item));
            Destroy(this.GetComponent<Slot>().item);
        }    
        
    }

    
    void Start()
    {   
        originalParent = transform.parent;
    }
   

}
