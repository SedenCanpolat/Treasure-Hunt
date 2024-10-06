using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum taskType{
    DraggableItem=0, Cleaning=2, ChestSubtask

}
public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;
    public Task[] task;
    [SerializeField] GameObject player;
    public int taskId;
    public ExitHome exitHome;

    private void Awake() {
        if (instance != null && instance != this) 
        { 
            Destroy(this);
        } 
        else{ 
            instance = this; 
        } 
    }

    void Start()
    {

    }

    public int getTaskControl(int dialogIndex){
       for(int i=0; i<task.Length; i++){
            if(task[i].onMission == dialogIndex){
                Debug.Log("dialogindex:" + dialogIndex + "" + "onMission:" + task[i].onMission + "inMission" + task[i].inMission);
                dialogIndex = task[i].inMission;
            }   
        }
        return dialogIndex;
        //colorChanged = true;
    }

   

    public int finishTaskControl(int dialogIndex){
        for(int i=0; i<task.Length; i++){
            if(task[i].onMission == dialogIndex || task[i].inMission == dialogIndex ){
                if(task[i].isTaskDone){
                    dialogIndex = task[i].afterMission;

                }
            }
            if(task[task.Length - 1].isTaskDone){
                exitHome.ChangeScene();
            }
        }
        Debug.Log("finish:" + dialogIndex);
        return dialogIndex;
    }

    public void StopPlayerMovement(){
        player.GetComponent<PlayerMovement>().LockMovement();
    }

    public void StartPlayerMovement(){
        player.GetComponent<PlayerMovement>().UnlockMovement();
    }

   

    [System.Serializable]
    public class Task
    {
        public string taskName;
        public int onMission;
        public int inMission;
        public int afterMission;
        public bool isTaskDone;
        public bool enableScript;
        //public bool colorChanged;        

    }

}
