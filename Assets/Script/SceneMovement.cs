using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMovement : MonoBehaviour
{
    public GameObject[] sceneArr;


    private int currentSceneIndex = 0;

    void OnMouseDown()
    { // needs collider for interaction
        if (gameObject.tag == "Door")
        {
            if (currentSceneIndex < sceneArr.Length)
            {
                sceneArr[currentSceneIndex].SetActive(false);
                currentSceneIndex++;
                if (currentSceneIndex >= sceneArr.Length)
                {
                    currentSceneIndex = 0;
                }
                sceneArr[currentSceneIndex].SetActive(true);
            }

        }
    }



}