using UnityEngine;

public class SedenDeneme : MonoBehaviour
{
    //seenmovement
    private int currentSceneIndex = 0;
    public GameObject[] sceneArr; 

    // if(FindAnyObjectByType<OpenImageCanvas>()?.isImageActive == true) // if OpenImageCanvas exists and is active

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

    private void Update() {
        //gameObject.GetComponent<SceneMovement>().enabled = false; // Sadece SceneMovement in update i kapaniyor
        // Bu sekilde script i kapatamazsin
        // fonki kapatma da yok
        // ayni zamanda her frame bunu kontrol etmek kotu bir fikir
    }
}
