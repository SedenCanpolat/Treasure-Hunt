using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public static ImageManager instance; // tek yere atabilirsin sadece bunu kullaniyorsan

    [SerializeField] Image imageCanvas;
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
       CloseImageCanvas();
    }
    public void OpenImageCanvas(Sprite sprite){
        imageCanvas.transform.parent.gameObject.SetActive(true);
        imageCanvas.sprite = sprite;
    }

    public void CloseImageCanvas(){
        imageCanvas.transform.parent.gameObject.SetActive(false);
    }

}
