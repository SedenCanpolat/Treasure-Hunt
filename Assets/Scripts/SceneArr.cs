using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneArr : MonoBehaviour
{
    public GameObject[] sceneArr;
    void Start()
    {
        SceneMovement.instance.Initialize(sceneArr);
    }


}
