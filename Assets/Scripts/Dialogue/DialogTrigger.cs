using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    public int Active;
    public int End;


    public void StartDialogue(int active, int end)
    { // singleton also can be used
        Active = active;
        End = end;
        FindObjectOfType<DialogManager>().OpenDialogue(messages, actors, Active, End);
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
