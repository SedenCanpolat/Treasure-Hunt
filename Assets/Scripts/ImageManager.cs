using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public static ImageManager instance; // tek yere atabilirsin sadece bunu kullaniyorsan

    [SerializeField] Image imageCanvas;
    public bool isImageActive = false;
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
       //CloseImageCanvas();
    }
    public IEnumerator OpenImageCanvas(Sprite sprite, int waitms=0){
        //FindAnyObjectByType<PlayerMovement>().enabled = false; // only update closed
        FindAnyObjectByType<PlayerMovement>().isLocked = true;
        yield return new WaitForSeconds(waitms / 1000f);
        imageCanvas.transform.parent.gameObject.SetActive(true);
        imageCanvas.sprite = sprite;
        isImageActive = true;
        
    }

    public void CloseImageCanvas(){
        imageCanvas.transform.parent.gameObject.SetActive(false);
        isImageActive = false;
        FindAnyObjectByType<PlayerMovement>().isLocked = false;
        FindAnyObjectByType<DialogManager>().FinishDialog();
    }

}
