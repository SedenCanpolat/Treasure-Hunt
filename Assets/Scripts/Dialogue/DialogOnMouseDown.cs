using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOnMouseDown : MonoBehaviour
{
    public DialogTrigger trigger;
    void OnMouseDown()
    {
        Debug.Log("aa");
        trigger.StartDialogue();
    }
}
