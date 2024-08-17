using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHome : MonoBehaviour
{
    public SceneMan sceneMan;
    public ChestSubtask chestSubtask;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        if (chestSubtask.tasksDone == true)
        {
            sceneMan.ChangeScene(2);
        }

    }
}
