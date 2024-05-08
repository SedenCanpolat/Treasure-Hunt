using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;


public class Cleaning : Interactable
{
    Vector2 viledaStartPos;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject dirtParent;
    bool missionCompleted;

    private void Start() {
        viledaStartPos = transform.position;
    }

    private void OnMouseDown() {
        //isActive = false;
        //playerMovement.enabled = false;
    }

    private void OnMouseEnter() {
        playerMovement.enabled = false;
    }

    private void OnMouseExit() {
        playerMovement.enabled = true;
    }

    private void OnMouseDrag() {
        Vector2 mousePos = HolyUtilities.GetMouseWorldPos();
        if(mousePos.y < 5){
            gameObject.transform.position = mousePos;  
        }
        
        
    }

    private void OnMouseUp() {
        //isActive = true;
        transform.position = viledaStartPos;
        //playerMovement.enabled = true;
        if(dirtParent.transform.childCount == 0 && missionCompleted == false){
            print("YEYY");
            missionCompleted = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Dirt dirtComp = other.GetComponent<Dirt>();
        if(dirtComp){
            dirtComp.Clean();
        }
        // other.GetComponent<Dirt>()?.Clean();
    }

}
