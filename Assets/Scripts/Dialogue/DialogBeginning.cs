using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class DialogBeginning : MonoBehaviour
{
    public DialogTrigger trigger;
    [SerializeField] AudioClip BirdSFX;
    
    void Start()
    {
        FindObjectOfType<GeneralTransition>().SceneChangend();
        SoundEffectController.PlaySFX(BirdSFX).SetVolume(1.40f);
        trigger.StartDialogue();
    }

}

