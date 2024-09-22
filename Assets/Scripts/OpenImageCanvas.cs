using UnityEngine;
using Holylib.Utilities;
using Holylib.HolySoundEffects;

public class OpenImageCanvas : DialogTrigger
{
    [SerializeField] Sprite sprite;
    [SerializeField] AudioClip ImageOpeningSFX;
    public bool opened = false;
    
    
    protected override void OnMouseDown(){ // inheritance
         if(isActive && !HolyUtilities.isOnUI()){
            
            if (ImageOpeningSFX != null) {
                SoundEffectController.PlaySFX(ImageOpeningSFX);
            }
            Invoke("ImageOpening", 0.5f);        
        }
    }

    public void ImageOpening(){
        ImageManager.instance.OpenImageCanvas(sprite);
        /* 
        if(ImageManager.instance.isImageActive == false){
            opened = false;
            
        }
        opened = true;
        Debug.Log("Image Opened");
       */ 
        TriggerDialog();
        
    }


}
