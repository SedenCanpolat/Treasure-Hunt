using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagBehavior : MonoBehaviour
{
    [SerializeField] float closeDuration;
    [SerializeField] GameObject content;
    
    Vector2 originalPosition;
    bool isOpen = true;

    private void Start() {
        originalPosition = content.transform.position;
    }
    

    public void OpenCloseBag(){
        isOpen = !isOpen;
        content.gameObject.LeanCancel();
        if (isOpen){
            content.transform.position = new Vector2(transform.position.x, content.transform.position.y);
            LeanTween.moveX(content.gameObject, originalPosition.x, closeDuration);
        }
        else{
            content.transform.position = new Vector2(originalPosition.x, content.transform.position.y);
            LeanTween.moveX(content.gameObject, transform.position.x,closeDuration);
        }    
       
    }
    
}
