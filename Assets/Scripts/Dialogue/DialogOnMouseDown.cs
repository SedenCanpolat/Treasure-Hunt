using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnMouseDown : Interactable // delete
{
    public int mission;
    public DialogTrigger trigger;
    public Dialogs[] dialogs;
    
    
    void OnMouseDown()
    {
        if(isActive){
            trigger.StartDialogue();
        }

        /*
        if(isActive){
            if (mission == 0)
            trigger.StartDialogue();
            if (mission == 1)
            trigger.MissionDialogue();
            if (mission == 2)
            trigger.CompletedMissionDialogue();
        }
        */
        
        
    }
}

