using UnityEngine;

public class DT : Interactable
{
   
    public bool tasksDone = false;
    public Actor[] actors;
    public int dialogIndex;
    public Dialogs[] dialogs;
    
    public bool doesSubtaskExist = false;    


    private OpenImageCanvas openImageCanvas;

    private void Start()
    {
        openImageCanvas = FindObjectOfType<OpenImageCanvas>();
    }

    public void StartDialogue()
    {
        // FindObjectOfType<DialogManager>().OpenDialogue(dialogs[dialogIndex].dialog, actors);
    }

    protected virtual void OnMouseDown()
    {
        TriggerDialog();
    }

    protected virtual void TriggerDialog()
    {
        if (isActive && doesSubtaskExist)
        {

            dialogIndex = TaskManager.instance.finishTaskControl(dialogIndex);
            //GetComponent<LeanBreathing>().StartBreathing();
            Debug.Log("DT: " + dialogIndex);
            StartDialogue();
            dialogIndex = TaskManager.instance.getTaskControl(dialogIndex);


        }
        else if(isActive){
            
            StartDialogue();
            if (dialogs.Length > 1 && dialogIndex == 0) dialogIndex = 1;

        }
    }
}

[System.Serializable] // to make the class + struct changeable & to see it
public class Mesaj
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Aktor
{
    public string name;
    public Sprite sprite;
}


[System.Serializable]
public struct Dialog
{
    public Message[] dialog;
}
