using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest2 : MonoBehaviour
{
    public static Chest2 instance;
    public ChestSubtask chestSubtask;
    
    private void Awake() {
        if (instance != null && instance != this) 
        { 
        Destroy(this); 
        } 
        else{ 
            instance = this; 
        } 
    }

    public void OpenChest(){
        Debug.Log("Chest is opened");
        chestSubtask.OpenChest();
        
    }
}
