using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    public float dirtiness;
    [SerializeField] SpriteRenderer dirtSprite;

    public void Clean(){
        dirtiness -= 0.15f; // rgb 0-1 alpha
        Color dirtColor = dirtSprite.color;
        dirtColor.a = dirtiness;
        dirtSprite.color = dirtColor;

        if(dirtiness <= 0.20f){
            Destroy(this.gameObject);
        }
    }
}
