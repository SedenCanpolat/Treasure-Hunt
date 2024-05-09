using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class PlayerMovement : MonoBehaviour
{
    public Floor floorScript;
    public float speed = 10f;

    public float xRange;
    public float yRange;
    Vector2 lastClickedPos;
    bool moving;

    private int lockCount = 0;
    [SerializeField] AudioClip walkSFX;
    SoundSource walksound;

    void Update()
    {
        //if(lockCount > 0)   return;
        if(isLocked) return;

        //if (DialogManager.isActive == true) //if dialogue is open, then character not moving
            //return;

        if (Input.GetMouseButtonDown(0) && floorScript.check)
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            if (!walksound)
                walksound = SoundEffectController.PlaySFX(walkSFX).SetVolume(1.60f).RandomPitchRange(1.60f, 2.40f).SetLoop(true);

            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            floorScript.check = false;
        }
        else
        {
            CancelMovement();
        }
    }

    public bool isLocked{ // getter setter
        get{
            return lockCount>0;
        } 
        set{
            if(value == true){
                lockCount++;
                CancelMovement();
            }
            else{
                lockCount--;
            }
        }
        // only I can take(get) its value, I cannot put(set) value inside of it 
    }



    public void LockMovement(){
        lockCount++;
        CancelMovement();
    }

    public void UnlockMovement(){
        lockCount--;
    }

    void CancelMovement(){
        moving = false;
            floorScript.check = false;
            if (walksound)
            {
                SoundEffectController.StopSFX(walksound);
                walksound = null;
            }
    }

}
