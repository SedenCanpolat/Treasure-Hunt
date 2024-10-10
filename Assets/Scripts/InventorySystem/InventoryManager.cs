using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    [SerializeField] Image itemImage;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this); // self destruction for singularity
        }
        else
        {
            instance = this;
        }
    }

    public void addItem(Sprite sprite)
    {
        itemImage.sprite = sprite;
        Debug.Log("çalışıyor");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
