using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Pipeline;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;
    public Task[] task;
    [SerializeField] GameObject player;
    
    public int taskId;

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

    public int findTaskNum(int dialogIndex){
        for(int i=0; i<task.Length; i++){
            Debug.Log("dialogindex:" + dialogIndex + "" + "onMission:" + task[i].onMission);
            if(task[i].onMission == dialogIndex){
                return i;
            }   
        }
        return dialogIndex;
    }

    public int getTaskControl(int dialogIndex){
        int thisTask = findTaskNum(dialogIndex);
        dialogIndex = task[thisTask].inMission; // ++
        //task[thisTask].enableScript = true;
        taskId = thisTask;
        return dialogIndex;
        //colorChanged = true;
    }

   

    public int finishTaskControl(int dialogIndex){
        int thisTask = findTaskNum(dialogIndex);
        if(task[thisTask].isTaskDone){
            dialogIndex = task[thisTask].afterMission;
            //task[thisTask].enableScript = false;
        }
        return dialogIndex;
    }

    public void StopPlayerMovement(){
        player.GetComponent<PlayerMovement>().LockMovement();
    }

    public void StartPlayerMovement(){
        player.GetComponent<PlayerMovement>().UnlockMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
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
