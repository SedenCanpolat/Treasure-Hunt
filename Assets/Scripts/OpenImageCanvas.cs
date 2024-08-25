using UnityEngine;
using Holylib.Utilities;
using Holylib.HolySoundEffects;

public class OpenImageCanvas : DialogTrigger
{
    [SerializeField] Sprite sprite;
    [SerializeField] AudioClip ImageOpeningSFX;
    
    
    protected override void OnMouseDown(){ // inheritance
         if(isActive && !HolyUtilities.isOnUI()){
            
            if (ImageOpeningSFX != null) {
                SoundEffectController.PlaySFX(ImageOpeningSFX);
            }
            Invoke("ImageOpening", 1f);           
        }
    }

    public void ImageOpening(){
        ImageManager.instance.OpenImageCanvas(sprite); 
        
        TriggerDialog();
    }


}
