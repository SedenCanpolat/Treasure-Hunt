using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnMouseDown : MonoBehaviour
{
    public int mission;
    public int check_on;
    public int check_off;
    public int length;
    public DialogTrigger trigger;
    void OnMouseDown()
    {
        if (mission == -1)
        {
            trigger.StartDialogue(0, check_on);
        }
        else if (mission == 0)
        {
            trigger.StartDialogue(check_on, check_off);
        }
        else if (mission == 1)
        {
            trigger.StartDialogue(check_off, length);
        }

    }

}
