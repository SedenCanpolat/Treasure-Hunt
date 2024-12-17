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
        transform.SetParent(transform.parent.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = startPos;
        transform.SetParent(originalParent, true);
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction, Mathf.Infinity);
            
            for(int i=0; i<hits.Length; i++){
                Debug.Log(hits[i].collider.name);
                if(hits[i].collider != null && hits[i].collider.gameObject == InventoryManager.instance.rightPlaceInDictionary(this.GetComponent<Slot>().item)){
                Debug.Log(InventoryManager.instance.rightPlaceInDictionary(this.GetComponent<Slot>().item));
                Destroy(this.gameObject);
            } 
        }
           
        
    }

    
    void Start()
    {   
        originalParent = transform.parent;
    }
   

}
