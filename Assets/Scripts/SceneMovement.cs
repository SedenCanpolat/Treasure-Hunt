using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMovement : MonoBehaviour
{
    //seenmovement
    public GameObject[] sceneArr;


    //private int currentSceneIndex = 0; 

    public static SceneMovement instance; // tek yere atabilirsin sadece bunu kullaniyorsan

    private void Awake() {
        if (instance != null && instance != this) 
        { 
        Destroy(this); // self destruction for singularity
        } 
        else{ 
            instance = this; 
        } 
    }

    private void Start() {
        changeScene(0);
    }

    public void changeScene(int roomId){
        for(int i = 0; i< sceneArr.Length; i++){
            sceneArr[i].SetActive(false);
        }
        sceneArr[roomId].SetActive(true);
    }


    void OnMouseDown(){ // needs collider for interaction
        //if(gameObject.tag == "Door"){ 
            // burada olmasina gerek yok cunku zaten bu script door un icinde
            // kapiya tiklayinca calisacak
            /*
            if(currentSceneIndex < sceneArr.Length){
                sceneArr[currentSceneIndex].SetActive(false);
                currentSceneIndex++;
                if(currentSceneIndex >= sceneArr.Length){
                    currentSceneIndex = 0;
                }
                sceneArr[currentSceneIndex].SetActive(true);
            }
            */
            
    }



}