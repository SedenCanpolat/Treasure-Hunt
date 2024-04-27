using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;
    public Message[] mission;
    public Message[] completed_mission;
    public Actor[] actors;


    public void StartDialogue()
    { // singleton also can be used
        FindObjectOfType<DialogManager>().OpenDialogue(messages, actors);
    }
    public void MissionDialogue()
    { // singleton also can be used
        FindObjectOfType<DialogManager>().OpenDialogue(mission, actors);
    }

    public void CompletedMissionDialogue()
    { // singleton also can be used
        FindObjectOfType<DialogManager>().OpenDialogue(completed_mission, actors);
    }
}

[System.Serializable] // to make the class changeable & to see it
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
