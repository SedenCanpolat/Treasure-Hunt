using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public GameObject slot;
    public void createSlot(Sprite sprite){
        GameObject newSlot = Instantiate(slot, this.gameObject.transform);
        newSlot.GetComponent<Image>().sprite = sprite;

       
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
