using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public int roomId;
    void OnMouseDown(){
        SceneMovement.instance.changeScene(roomId);
    }   
}
