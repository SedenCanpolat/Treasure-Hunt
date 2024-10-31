using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public GameObject slot;
    public void createSlot(Item item)
    {
        GameObject newSlot = Instantiate(slot, this.gameObject.transform);
        newSlot.GetComponent<Slot>().setSlot(item);

    }

    public void deleteSlot(Item item)
    {
        
    }    
    
}
