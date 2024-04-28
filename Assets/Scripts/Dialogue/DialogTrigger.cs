using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class DialogTrigger : Interactable
{
    //public Message[] messages;
    //public Message[] mission;
    //public Message[] completed_mission;
    public Actor[] actors;

    public int dialodIndex;
    public Dialogs[] dialogs;
    
    


    public void StartDialogue()
    { 
        FindObjectOfType<DialogManager>().OpenDialogue(dialogs[dialodIndex].dialog, actors);
    }

    void OnMouseDown()
    {
        if(isActive){
           StartDialogue();
        }        
        
    }

    
    /*
    public void MissionDialogue()
    { 
        FindObjectOfType<DialogManager>().OpenDialogue(mission, actors);
    }

    public void CompletedMissionDialogue()
    { 
        FindObjectOfType<DialogManager>().OpenDialogue(completed_mission, actors);
    }
    */

}

[System.Serializable] // to make the class + struct changeable & to see it
public class Message
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}


[System.Serializable]
public struct Dialogs{
    public Message[] dialog;
}
