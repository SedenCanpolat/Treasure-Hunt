using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Floor floorScript;
    public float speed = 10f;

    public float xRange;
    public float yRange;
    Vector2 lastClickedPos;
    bool moving;

    void Update()
    {
        if (DialogManager.isActive == true) //if dialogue is open, then character not moving
            return;

        if (Input.GetMouseButtonDown(0) && floorScript.check)
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;

        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            floorScript.check = false;
        }
        else
        {
            moving = false;
            floorScript.check = false;
        }
    }
}
