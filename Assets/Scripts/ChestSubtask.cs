using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.Utilities;
using UnityEngine.UI;
using Holylib.HolySoundEffects;

public class ChestSubtask : Interactable
{
    [SerializeField] Sprite sprite;
    [SerializeField] AudioClip ImageOpeningSFX;

    public SubTask subTask;
    public DialogTrigger dialogTrigger;
    void OnMouseDown()
    {
        if (isActive && !HolyUtilities.isOnUI())
        {
            SoundEffectController.PlaySFX(ImageOpeningSFX);
            Invoke("ImageOpening", 1f);
            if (dialogTrigger.dialogIndex == subTask.task[1].getTask + 1) dialogTrigger.dialogIndex++;

        }
    }

    void ImageOpening()
    {
        ImageManager.instance.OpenImageCanvas(sprite);
    }

}

