using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(int sceneIndex){
        LevelManagement.instance.ChangeLevelWithTransition(sceneIndex);
    }
}
