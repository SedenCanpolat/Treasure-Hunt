using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] Image itemImage;
    
  
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

    public void addItem(Sprite sprite)
    {
        FindAnyObjectByType<Slots>().createSlot(sprite);
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

    public int isRightPlace(int check){
        return check;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
