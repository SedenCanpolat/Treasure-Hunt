using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima: MonoBehaviour
{
    private float xTres = 6f;
    private float yAmount = -1f; 
    bool over = false;

    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        LeanTween.moveX(gameObject, xTres, 3f);
        LeanTween.moveY(gameObject, yAmount, 3f);
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
            LeanTween.moveX(gameObject, 3f , 3f);
            LeanTween.moveY(gameObject, -0.5f, 3f);
            Invoke("Move", 5f);
            over = false;
        
        
    }
    private void Move3()
    {   
            animator.SetBool("IsAtMost", false);
            LeanTween.moveX(gameObject, 3f , 3f);
            Invoke("Move", 5f);
            over = true;
          
    }

    private void Move4()
    {
        LeanTween.moveX(gameObject, 3f, 3f);
        LeanTween.moveY(gameObject, -0.5f, 3f);
        animator.SetBool("IsAtMost", false);
        Invoke("Move", 5f);
    }
}
