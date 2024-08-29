using UnityEngine;

public class DialogTrigger : Interactable
{
    public ExitHome exitHome;
    public bool tasksDone = false;
    public SubTask subTask;
    public Actor[] actors;
    public int dialogIndex;
    public Dialogs[] dialogs;
    public bool check = false;
    

    private OpenImageCanvas openImageCanvas;

    private void Start() {
        openImageCanvas = FindObjectOfType<OpenImageCanvas>();
    }

    public void StartDialogue()
    {
        FindObjectOfType<DialogManager>().OpenDialogue(dialogs[dialogIndex].dialog, actors);
    }

    protected virtual void OnMouseDown()
    {
        TriggerDialog();
        /*
        if (openImageCanvas == null)
        {
            Debug.Log("OpenImageCanvas is null");
            TriggerDialog();
        }
        if(openImageCanvas != null && openImageCanvas.opened == false)
        {
            TriggerDialog();
        }
        if(openImageCanvas != null && ImageManager.instance.isImageActive == false)
        {
            TriggerDialog();
        }
        */
        
    }

    protected virtual void TriggerDialog()
    {
        if (isActive && this.gameObject.name == "Capsule")
        {
            GetComponent<LeanBreathing>().StartBreathing();
            //Debug.Log(dialogs.Length);
            //Debug.Log(dialogIndex);
            StartDialogue();
            for (int i = 0; i < subTask.taskNum; i++)
            {
                if (dialogIndex == subTask.task[i].getTask) dialogIndex++;
            }
            //Debug.Log("control: ");
            //Debug.Log(tasksDone);
            if (dialogIndex >= subTask.task[subTask.taskNum - 1].getTask)
            {
                subTask.allTasksDone = true;
                //Debug.Log("control: ");
                //Debug.Log(tasksDone);
            }

            
        }
        else if (isActive && this.gameObject.name == "HomeDoor")
        {
            //Debug.Log(dialogs.Length);
            //Debug.Log(dialogIndex);

            if (dialogIndex == 1)
            {
                exitHome.ChangeScene();
            }
            else if (subTask.allTasksDone == true && dialogIndex == 0)
            {
                dialogIndex++;
            }
            StartDialogue();
            Debug.Log(dialogIndex);
        }
        else if (isActive)
        {
            
            //Debug.Log(dialogs.Length);
            //Debug.Log(dialogIndex);
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
