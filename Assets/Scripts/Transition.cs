using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Transition : Interactable
{
    //Transition inherit from Interactable
    public int roomId;
    public Vector2 supposedPosition;

    private GameObject player;

    [SerializeField] CanvasGroup LoadCanvas;
    [SerializeField] GameObject LoadImage;
    [SerializeField] float to;
    [SerializeField] float time;
    [SerializeField] float delay;
    
    

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    

    void OnMouseDown(){
        if(isActive){
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
