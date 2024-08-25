using UnityEngine;
using Holylib.HolySoundEffects;

public class DialogBeginning : MonoBehaviour
{
    public DialogTrigger trigger;
    [SerializeField] AudioClip BirdSFX;
    
    void Start()
    {
        
        SoundEffectController.PlaySFX(BirdSFX).SetVolume(2.00f).RandomPitchRange(0.90f,1.05f);
        trigger.StartDialogue();
    }

}

