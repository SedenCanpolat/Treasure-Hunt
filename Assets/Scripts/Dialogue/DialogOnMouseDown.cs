using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnMouseDown : MonoBehaviour
{
    public int mission;
    public DialogTrigger trigger;
    void OnMouseDown()
    {
        if (mission == -1)
            trigger.StartDialogue();
        if (mission == 0)
            trigger.MissionDialogue();
        if (mission == 1)
            trigger.CompletedMissionDialogue();
    }
}
