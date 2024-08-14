using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;
using UnityEngine.UI;
using Holylib.HolySoundEffects;

public class OpenImageCanvas : Interactable
{
    [SerializeField] Sprite sprite;
    [SerializeField] AudioClip ImageOpeningSFX;
    void OnMouseDown(){
         if(isActive && !HolyUtilities.isOnUI()){
            SoundEffectController.PlaySFX(ImageOpeningSFX);
            Invoke("ImageOpening", 1f);
                       
        }
    }

    void ImageOpening(){
        ImageManager.instance.OpenImageCanvas(sprite); 
    }

}
