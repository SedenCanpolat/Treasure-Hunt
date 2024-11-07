using System.Collections;
using System.Collections.Generic;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;

public class BagBehavior : MonoBehaviour
{
    [SerializeField] float closeDuration;
    [SerializeField] GameObject content;
    Transform originalPosition;
    bool isOpen = false;

    private void Start() {
        originalPosition = content.transform;
    }
    public void openBag(){
        foreach (Transform item in content.transform) 
        {
            LeanTween.moveX(item.gameObject, 250, closeDuration);
        }

        LeanTween.delayedCall(closeDuration, () =>
        {
            foreach (Transform child in content.transform)
            {
                child.gameObject.SetActive(false);
            }
            isOpen = true;
        });
        
    }

    public void closeBag(){
        if(isOpen){
            Debug.Log("b");
            LeanTween.moveX(content, originalPosition.position.x, closeDuration);
        }
        
    }
       
    
}
