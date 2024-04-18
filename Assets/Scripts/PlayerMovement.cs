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
        }
    }

    public void movement()
    {
        lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if ((Vector2)transform.position != lastClickedPos)
        {
            float step = speed * 0.1f;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, speed);
        }
    }
}
