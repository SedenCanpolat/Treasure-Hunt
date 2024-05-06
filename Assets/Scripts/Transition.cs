using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Holylib.HolySoundEffects;
using Holylib.Utilities;
using UnityEngine.PlayerLoop;

public class Transition : Interactable
{
    //Transition inherit from Interactable
    public int roomId;
    public Vector2 supposedPosition;

    private GameObject player;

    [SerializeField] CanvasGroup LoadCanvas;
    [SerializeField] float time;
    [SerializeField] AudioClip StairSFX;
    
    

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnMouseDown(){
        if(isActive && !HolyUtilities.isOnUI()){
            SoundEffectController.PlaySFX(StairSFX).SetVolume(2.00f).RandomPitchRange(0.90f,1.05f);
            LoadCanvas.gameObject.LeanCancel(); // to cancel the previous for spamming
            LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(1f, time).setOnComplete(SceneChangend); // call the function inside of it when it's completed
        }

    } 

    void SceneChangend(){
        SceneMovement.instance.changeScene(roomId);        
        player.transform.position = supposedPosition;
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(0f, time);
        
    }  
}
