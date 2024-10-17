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

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("bb");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("cc");
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.position = startPos;
        Debug.Log("dd");
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
        Deug.Log()


    }

    // Update is called once per frame
    void Update()
    {

    }
}
