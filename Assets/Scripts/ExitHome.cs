using UnityEngine;
using Holylib.HolySoundEffects;

public class ExitHome : MonoBehaviour
{
    public SceneMan sceneMan;
    //public DialogTrigger dialogTrigger;

    public AudioClip ExitHomeSFX;


    void OnMouseDown()
    {
        //if (dialogTrigger.tasksDone == true)
        //{
        //     SoundEffectController.PlaySFX(ExitHomeSFX);
        //    Invoke("ChangeScene", 1.5f);

        //}
    }

    public void ChangeScene()
    {
        sceneMan.ChangeScene(2);
        SoundEffectController.PlaySFX(ExitHomeSFX);
        Invoke("ChangeScene", 1.5f);
        //LevelManagement.instance.ChangeLevelWithTransition(2);

    }
}
