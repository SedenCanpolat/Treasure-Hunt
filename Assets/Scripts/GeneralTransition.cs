using System;
using UnityEngine;

public class GeneralTransition : MonoBehaviour
{
    [SerializeField] CanvasGroup LoadCanvas;


    public void MakeTransition(Action afterTransitionFunc){ // void delegate
        LoadCanvas.GetComponent<CanvasGroup>().alpha = 0f;
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(1f, 0.7f).setIgnoreTimeScale(true).setOnComplete(afterTransitionFunc);
    }

    public void SceneChangend(){
        LoadCanvas.GetComponent<CanvasGroup>().alpha = 1f;
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(0f, 0.7f).setIgnoreTimeScale(true);
        
    }  


}