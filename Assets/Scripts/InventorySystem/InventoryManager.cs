using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] Image itemImage;
    public ObjectMatch objectMatch;
    
  
    public int index;
    

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void addItem(Item item)
    {
        FindAnyObjectByType<Slots>().createSlot(item);
        //itemImage.sprite = sprite;
        Debug.Log("çalışıyor");
    }

    public void addList()
    {
        Debug.Log("list");
    }

    public void takeItem(Sprite sprite)
    {
        itemImage.sprite = sprite;
        Debug.Log("çalışıyor");
    }

    public GameObject rightPlaceInDictionary(Item item){
        foreach (var kvp in objectMatch.ObjectTargetDictionary){
            if(item == kvp.Key){
                return kvp.Value;
            }
        }
        return null;
    }

}
