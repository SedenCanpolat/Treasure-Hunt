using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class DialogTrigger : Interactable
{

    public Actor[] actors;
    public int dialogIndex;
    public Dialogs[] dialogs;
    public bool check = false;

    public void StartDialogue()
    {
        FindObjectOfType<DialogManager>().OpenDialogue(dialogs[dialogIndex].dialog, actors);
    }

    void OnMouseDown()
    {
        if (isActive)
        {
            Debug.Log(dialogs.Length);
            Debug.Log(dialogIndex);
            StartDialogue();
            if (dialogs.Length > 1 && dialogIndex == 0) dialogIndex = 1;
        }

    }
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
public struct Dialogs
{
    public Message[] dialog;
}
