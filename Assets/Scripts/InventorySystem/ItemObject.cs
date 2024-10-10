using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    [SerializeField] SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    public void Start()
    {
        spriteRenderer.sprite = item.sprite;
    }

    public void OnMouseEnter()
    {
        InventoryManager.instance.addItem(item.sprite);
        Debug.Log("" + item.sprite);
        Destroy(this.gameObject);
    }



}
