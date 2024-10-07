using UnityEngine;

public class DialogTrigger : Interactable
{
    public ExitHome exitHome;
    public ChestSubtask chestSubtask;
    public bool tasksDone = false;
    public SubTask subTask;
    public Actor[] actors;
    public int dialogIndex;
    public Dialogs[] dialogs;
    public bool check = false;


    private OpenImageCanvas openImageCanvas;

    private void Start()
    {
        openImageCanvas = FindObjectOfType<OpenImageCanvas>();
    }

    public void StartDialogue(int waitms)
    {
        FindObjectOfType<DialogManager>().StartCoroutine(
        FindObjectOfType<DialogManager>().OpenDialogue(dialogs[dialogIndex].dialog, actors, waitms)
        );
    }

    protected virtual void OnMouseDown()
    {
        TriggerDialog();

    }

    protected virtual void TriggerDialog(int waitms =0)
    {
        
        if (isActive && this.gameObject.name == "Capsule")
        {
            GetComponent<LeanBreathing>().StartBreathing();
            //Debug.Log(dialogs.Length);
            //Debug.Log(dialogIndex);
            StartDialogue(waitms);
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

            //if (dialogIndex == 1)
            //{
            //if(tasksDone){
            //exitHome.ChangeScene();
            //} 
            //}
            if (subTask.allTasksDone == true && dialogIndex == 0)
            {
                dialogIndex=1;
                exitHome.ChangeScene();
            }
            StartDialogue(waitms);
            Debug.Log(dialogIndex);
        }

        else if (isActive && this.gameObject.name == "haritaKoli")
        {
            if (chestSubtask.checkchest)
            {
                StartDialogue(waitms);
                if (dialogIndex == 0)
                    dialogIndex = 1;
            }
        }

        else if (isActive)
        {
            //Debug.Log(dialogs.Length);
            //Debug.Log(dialogIndex);
            StartDialogue(waitms);
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
