using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;
using Holylib.Utilities;

public class WaitingSFX : DialogTrigger
{
    [SerializeField] AudioClip WaitSFX;
    protected override void OnMouseDown(){ // inheritance
         if(isActive && !HolyUtilities.isOnUI()){
            
            if (WaitSFX != null) {
                SoundEffectController.PlaySFX(WaitSFX);
            }
            //Invoke("DialogTime", 0.6f); 
            TriggerDialog(600);       
        }
    }

    //public void DialogTime(){
        
    //}
}
