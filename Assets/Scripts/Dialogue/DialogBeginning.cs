using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBeginning : MonoBehaviour
{
    public DialogTrigger trigger;
    
    void Start()
    {
        trigger.StartDialogue();
    }

}

