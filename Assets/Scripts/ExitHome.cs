using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class ExitHome : MonoBehaviour
{
    public SceneMan sceneMan;
    public ChestSubtask chestSubtask;

    public AudioClip ExitHomeSFX;
   
    void OnMouseDown()
    {
        if (chestSubtask.tasksDone == true)
        {
            SoundEffectController.PlaySFX(ExitHomeSFX);
            sceneMan.ChangeScene(2);
        }

    }
}
