using UnityEngine;

public class SubTask : MonoBehaviour
{
    public bool allTasksDone = false;
    public int clothesNum;
    public Task[] task;
    public int taskNum;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}

[System.Serializable]
public class Task
{
    public string taskName;
    public int getTask;
}