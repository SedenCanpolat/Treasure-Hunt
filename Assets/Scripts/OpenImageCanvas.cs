using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;
using UnityEngine.UI;

public class OpenImageCanvas : Interactable
{
    [SerializeField] Sprite sprite;
    [SerializeField] AudioClip ImageOpeningSFX;
    void OnMouseDown(){
         if(isActive && !HolyUtilities.isOnUI()){
            ImageManager.instance.OpenImageCanvas(sprite);
        }
    }
}
