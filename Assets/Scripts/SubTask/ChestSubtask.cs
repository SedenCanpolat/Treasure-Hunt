using UnityEngine;
using Holylib.Utilities;
using Holylib.HolySoundEffects;

public class ChestSubtask : Interactable
{
    public bool tasksDone = false;
    [SerializeField] GameObject lockImg;
    [SerializeField] GameObject unlockImg;
    [SerializeField] Sprite mapImg;
    [SerializeField] AudioClip LockSFX;
    [SerializeField] AudioClip MapSFX;

    public SubTask subTask;
    public DialogTrigger dialogTrigger;

    private void Start() {
        unlockImg.SetActive(false);
    }
    void OnMouseDown()
    {
        if (isActive && !HolyUtilities.isOnUI() && dialogTrigger.dialogIndex < subTask.task[3].getTask + 1)
        {
            SoundEffectController.PlaySFX(LockSFX);
            //Invoke("LockImageOpening", 1f);
            //LockImageOpening();
            ImageInSceneOpening(lockImg);
            if (dialogTrigger.dialogIndex == subTask.task[1].getTask + 1) dialogTrigger.dialogIndex++;
        }
        else if (isActive && !HolyUtilities.isOnUI())
        {
            SoundEffectController.PlaySFX(MapSFX).SetVolume(0.4f);
            //Invoke("MapImageOpening", 1f);
            ImageInSceneClosing(lockImg);
            ImageInSceneOpening(unlockImg);
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
        // ImageManager.instance.OpenImageCanvas(lockImg);
    }
    void MapImageOpening()
    {
        ImageManager.instance.OpenImageCanvas(mapImg);
    }

    void ImageInSceneOpening(GameObject image)
    {
        image.SetActive(true);
    }

    void ImageInSceneClosing(GameObject image)
    {
        image.SetActive(false);
    }

}

