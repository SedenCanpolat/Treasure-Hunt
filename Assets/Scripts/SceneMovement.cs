using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMovement : MonoBehaviour
{
    public GameObject[] sceneArr;

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

}