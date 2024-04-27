using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlClose : MonoBehaviour
{

    [SerializeField] GameObject[] closedObjects;


    // Update is called once per frame
    void Update()
    {
        if(DialogManager.isActive == true){
            /*
            for(int i=0; i<closedObjects.Length; i++){
                closedObjects[i].SetActive(false);
            }
             
            */
            //gameObject.GetComponent<SceneMovement>().enabled = false; // Sadece scenemovent update kapanıyor
            // fonki kapatma da yok
/*
            for(int i=0; i<closedObjects.Length; i++){
                closedObjects[i].GetComponent<Transition>().enabled = false;
            }
*/           

        }
        else{
            /*
            for(int i=0; i<closedObjects.Length; i++){
                closedObjects[i].SetActive(true);
            }
            
            for(int i=0; i<closedObjects.Length; i++){
                closedObjects[i].GetComponent<Transition>().enabled = true;
            }
            */
        }
        
    }
}
