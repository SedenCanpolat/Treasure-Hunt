using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;

    public void setSlot(Item item){
        this.item = item;
        GetComponent<Image>().sprite = item.sprite;
    }
}
