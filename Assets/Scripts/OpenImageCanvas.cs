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
            StartCoroutine(ImageManager.instance.OpenImageCanvas(sprite, 600));
            
            TriggerDialog(600);      
        }
    }


    public void CanvasWithoutDialogue(){
        if(isActive){
            print("a");
            
                    print("b");
                    if (ImageOpeningSFX != null) {
                    SoundEffectController.PlaySFX(ImageOpeningSFX);
                    }
                    StartCoroutine(ImageManager.instance.OpenImageCanvas(sprite));
            
                
            
            
        }
    }


}
