using UnityEngine;

public class SceneMovement : MonoBehaviour
{
    private GameObject[] sceneArr;

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


    public void Initialize(GameObject[] scenes){
        sceneArr = scenes;
        changeScene(0);  
    }


    public void changeScene(int roomId){
        if (sceneArr == null || sceneArr.Length == 0){
            Debug.LogError("sceneArr is not set or is empty!");
            return;
        }

        for(int i = 0; i< sceneArr.Length; i++){
            sceneArr[i].SetActive(false);
        }

        sceneArr[roomId].SetActive(true);
        
    }

}