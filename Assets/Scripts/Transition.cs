using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public int roomId;
    public Vector2 supposedPosition;
    void OnMouseDown(){
        SceneMovement.instance.changeScene(roomId);
        /*
        if (GetComponent<PlayerMovement>().herePos != null){
            GetComponent<PlayerMovement>().herePos = supposedPosition;
        }
        */
        GameObject.FindGameObjectWithTag("Player").transform.position = supposedPosition;
    }   
}
