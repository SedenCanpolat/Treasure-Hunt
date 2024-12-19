using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    [SerializeField] SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer.sprite = item.sprite;
    }

    private void OnMouseDown()
    {
        InventoryManager.instance.addItem(item);
        Destroy(this.gameObject);
    }

    public void getObject()
    {
        InventoryManager.instance.addItem(item);
    }

}
