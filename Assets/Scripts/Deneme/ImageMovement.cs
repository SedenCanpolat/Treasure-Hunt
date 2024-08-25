using UnityEngine;

public class ImageMovement : MonoBehaviour
{
   public GameObject[] imageArr;

    public static ImageMovement instance; 

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
        for(int i = 0; i< imageArr.Length; i++){
            imageArr[i].SetActive(false);
        }
    }

    public void changeImage(int imageId){
        for(int i = 0; i< imageArr.Length; i++){
            imageArr[i].SetActive(false);
        }
        imageArr[imageId].SetActive(true);
    }
}
