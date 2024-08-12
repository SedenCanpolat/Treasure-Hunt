using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;

public class OpenImage : Interactable
{
    public int ImageId; // for the image we want to open
    // like rooms it will open the image
    void OnMouseDown(){
         if(isActive && !HolyUtilities.isOnUI()){
            ImageMovement.instance.changeImage(ImageId); // change the scene to the image
        }
    }
}
