using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneArr : MonoBehaviour
{
    public GameObject[] sceneArr;
    // Start is called before the first frame update
    void Start()
    {
        SceneMovement.instance.Initialize(sceneArr);
    }


}
