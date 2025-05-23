using UnityEngine;
using Holylib.HolySoundEffects;
using Holylib.Utilities;

public class Transition : Interactable
{
    //Transition inherit from Interactable
    public int roomId;
    public Vector2 supposedPosition;

    private GameObject player;

    [SerializeField] CanvasGroup LoadCanvas;
    [SerializeField] float time;
    [SerializeField] AudioClip StairSFX;
    
    

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnMouseDown(){
        UseStairs();
    } 

    public void UseStairs(){
        if(isActive && !HolyUtilities.isOnUI()){
            if(!ImageManager.instance.isImageActive){ 
                SoundEffectController.PlaySFX(StairSFX).SetVolume(2.00f).RandomPitchRange(0.90f,1.05f);
                LoadCanvas.gameObject.LeanCancel(); // to cancel the previous for spamming
                LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(1f, time).setOnComplete(SceneChangend); // call the function inside of it when it's completed
            }
        }
    }

    public void SceneChangend(){
        SceneMovement.instance.changeScene(roomId);        
        player.transform.position = supposedPosition;
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(0f, time);
        
    }  
}
