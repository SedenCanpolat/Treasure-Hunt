using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanBreathing : MonoBehaviour
{
    [SerializeField] float rate;
    public void StartBreathing()
    {
        LeanTween.cancel(gameObject);
        gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        gameObject.LeanScale(new Vector3(rate, rate, rate), 0.7f).setLoopPingPong();
    }

     public void StopBreathing()
    {
        LeanTween.cancel(gameObject);  
    }
}
