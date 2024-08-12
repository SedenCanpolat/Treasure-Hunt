using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;
using Holylib.HolySoundEffects;


public class Cleaning : Interactable
{
    Vector2 viledaStartPos;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject dirtParent;
    bool missionCompleted;

    [SerializeField] AudioClip CleanSFX;
    [SerializeField] AudioClip CompleteSFX;
    [SerializeField] AudioClip PutSFX;
    SoundSource cleansource;

    private void Start() {
        viledaStartPos = transform.position;
    }

    private void OnMouseDown() {
        //isActive = false;
        playerMovement.isLocked = true; // playerMovement.LockMovement();
        cleansource = SoundEffectController.PlaySFX(CleanSFX).SetLoop(true).SetPitch(1.20f);
    }

    private void OnMouseEnter() {
        //playerMovement.enabled = false;
    }

    private void OnMouseExit() {
        //playerMovement.enabled = true;
    }

    private void OnMouseDrag() {
        Vector2 mousePos = HolyUtilities.GetMouseWorldPos();
        if(mousePos.y < 5){
            gameObject.transform.position = mousePos;  
        }
        
    }

    private void OnMouseUp() {
        //isActive = true;
        SoundEffectController.StopSFX(cleansource);
        transform.position = viledaStartPos;
        playerMovement.UnlockMovement();
        SoundEffectController.PlaySFX(PutSFX).SetVolume(0.90f);;
        if(dirtParent.transform.childCount == 0 && missionCompleted == false){
            print("YEYY");
            missionCompleted = true;
            SoundEffectController.PlaySFX(CompleteSFX).SetVolume(0.50f);
        }
    }

    private void OnTriggerEnter(Collider other) {
        Dirt dirtComp = other.GetComponent<Dirt>();
        if(dirtComp){
            dirtComp.Clean();
        }
        // other.GetComponent<Dirt>()?.Clean();
    }
}
