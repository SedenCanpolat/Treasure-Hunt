using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    public float xRange;
    public float yRange;
    Vector2 lastClickedPos;
    bool moving;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (lastClickedPos.x < xRange && lastClickedPos.x > -xRange && lastClickedPos.y < yRange)
            {
                moving = true;
            }
            else
            {
                moving = false;
            }
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        }
        else
        {
            moving = false;
        }
    }
}
