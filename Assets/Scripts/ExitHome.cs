using UnityEngine;
using Holylib.HolySoundEffects;

public class ExitHome : MonoBehaviour
{
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
        SoundEffectController.PlaySFX(ExitHomeSFX);
        Invoke("Ending", 1.5f);

    }

    void Ending()
    {
        LevelManagement.instance.ChangeLevelWithTransition(2);
    }
}
