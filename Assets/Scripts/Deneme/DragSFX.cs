using UnityEngine;
using Holylib.HolySoundEffects;

public class DragSFX : MonoBehaviour // delete
{
    public static AudioClip SFX;
    

    public void playSFX(){ //I have also tried static
        SoundEffectController.PlaySFX(SFX);
    }
}
