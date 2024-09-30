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
    public async void OpenImageCanvas(Sprite sprite, int waitms=0){
        //FindAnyObjectByType<PlayerMovement>().enabled = false; // only update closed
        FindAnyObjectByType<PlayerMovement>().isLocked = true;
        await System.Threading.Tasks.Task.Delay(waitms);
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
