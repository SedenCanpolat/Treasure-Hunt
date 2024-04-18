using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public int roomId;
    public Vector2 supposedPosition;

    private GameObject player;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
       
    }
    

    void OnMouseDown(){
        SceneMovement.instance.changeScene(roomId);
        
        player.transform.position = supposedPosition;
    }   
}
