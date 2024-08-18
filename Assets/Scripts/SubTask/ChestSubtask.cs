using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;
using UnityEngine.UI;
using Holylib.HolySoundEffects;

public class ChestSubtask : Interactable
{
    public bool tasksDone = false;
    [SerializeField] Sprite lockImg;
    [SerializeField] Sprite mapImg;
    [SerializeField] AudioClip LockSFX;
    [SerializeField] AudioClip MapSFX;

    public SubTask subTask;
    public DialogTrigger dialogTrigger;
    void OnMouseDown()
    {
        if (isActive && !HolyUtilities.isOnUI() && dialogTrigger.dialogIndex < subTask.task[3].getTask + 1)
        {
            SoundEffectController.PlaySFX(LockSFX);
            //Invoke("LockImageOpening", 1f);
            LockImageOpening();
            if (dialogTrigger.dialogIndex == subTask.task[1].getTask + 1) dialogTrigger.dialogIndex++;
        }
        else if (isActive && !HolyUtilities.isOnUI())
        {
            SoundEffectController.PlaySFX(MapSFX).SetVolume(0.5f);
            //Invoke("MapImageOpening", 1f);
            MapImageOpening();
            if (dialogTrigger.dialogIndex == subTask.task[3].getTask + 1)
            {
                dialogTrigger.dialogIndex++;
                tasksDone = true;
            }
        }
    }

    void LockImageOpening()
    {
        ImageManager.instance.OpenImageCanvas(lockImg);
    }
    void MapImageOpening()
    {
        ImageManager.instance.OpenImageCanvas(mapImg);
    }

}

