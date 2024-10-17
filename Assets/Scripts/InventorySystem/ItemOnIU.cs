using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Holylib.Utilities;
using UnityEngine.UI;
public class ItemOnIU : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    public void OnBeginDrag(PointerEventData eventData)
{
    Debug.Log("bb");
}
public void OnPointerEnter(PointerEventData pointerEventData)
{
    Debug.Log("aa");
}

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

}
}
