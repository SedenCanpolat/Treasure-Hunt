using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SedenDeneme : MonoBehaviour
{
    //seenmovement
    private int currentSceneIndex = 0;
    public GameObject[] sceneArr; 

     void OnMouseDown(){ // needs collider for interaction
        //if(gameObject.tag == "Door"){ 
            // burada olmasina gerek yok cunku zaten bu script door un icinde
            // kapiya tiklayinca calisacak
           
            if(currentSceneIndex < sceneArr.Length){
                sceneArr[currentSceneIndex].SetActive(false);
                currentSceneIndex++;
                if(currentSceneIndex >= sceneArr.Length){
                    currentSceneIndex = 0;
                }
                sceneArr[currentSceneIndex].SetActive(true);
            }
    }
}
