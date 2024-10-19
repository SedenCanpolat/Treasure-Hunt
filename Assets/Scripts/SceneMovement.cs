using UnityEditor.SearchService;
using UnityEngine;

public class SceneMovement : MonoBehaviour
{
    //public GameObject[] sceneArr;
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

    private void Start() {
        sceneArr = FindAnyObjectByType<SceneArr>().sceneArr;
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
        Debug.Log("Load correct one");
        sceneArr[roomId].SetActive(true);
    }

}