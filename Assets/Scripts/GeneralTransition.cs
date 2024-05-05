using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralTransition : MonoBehaviour
{
    [SerializeField] CanvasGroup LoadCanvas;

    void Start()
    {
        StartCoroutine(WaitBeforeShow());
    }

    public void makeTransition(){
        //LoadCanvas.gameObject.LeanCancel(); 
        print("a");
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(1f, 0.7f).setOnComplete(SceneChangend);
        StartCoroutine(WaitBeforeShow());
    }

    void SceneChangend(){
        LoadCanvas.GetComponent<CanvasGroup>().LeanAlpha(0f, 0.7f);
        
    }  


    
    IEnumerator WaitBeforeShow(){
        yield return new WaitForSeconds(20f);
        Debug.Log("b");
        FindObjectOfType<LevelManagement>().levelMan();
    }
}
