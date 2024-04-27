using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnMouseDown : Interactable
{
    public int mission;
    public DialogTrigger trigger;
    void OnMouseDown()
    {
        if(isActive){
            if (mission == -1)
            trigger.StartDialogue();
            if (mission == 0)
            trigger.MissionDialogue();
            if (mission == 1)
            trigger.CompletedMissionDialogue();
        }
        
        
    }
}
