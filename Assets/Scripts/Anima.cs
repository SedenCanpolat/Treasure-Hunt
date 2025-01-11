using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima: MonoBehaviour
{
    private float xTres = 6.25f;
    private float yTres = -1.25f; 
    bool over = false;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        Move5();
    }


    private void Move()
    {
        LeanTween.moveX(gameObject, xTres, 4.5f);
        LeanTween.moveY(gameObject, yTres, 4.5f);
        animator.SetBool("IsAtMost", true);
        Invoke("Move3", 5f);
        if(over)
        {
            Invoke("Move2", 5f);
        }
        
        
    }
    private void Move2()
    {   
            animator.SetBool("IsAtMost", false);
            LeanTween.moveX(gameObject, 2.5f , 4.5f);
            LeanTween.moveY(gameObject, 0f, 4.5f);
            Invoke("Move5", 5f);
            over = false;
        
        
    }
    private void Move3()
    {   
            animator.SetBool("IsAtMost", false);
            LeanTween.moveX(gameObject, 2.5f , 4.5f);
            Invoke("Move", 5f);
            over = true;
          
    }

    private void Move4()
    {
        LeanTween.moveX(gameObject, 2.5f, 4.5f);
        LeanTween.moveY(gameObject, yTres, 4.5f);
        animator.SetBool("IsAtMost", false);
        Invoke("Move5", 5f);
        over = true;
    }

    private void Move5()
    {
        LeanTween.moveX(gameObject, xTres, 4.5f);
        animator.SetBool("IsAtMost", true);
        
        if(over)
        {
            Invoke("Move2", 5f);
        }
        else
        {
            Invoke("Move4", 5f);
        }
    }
}
