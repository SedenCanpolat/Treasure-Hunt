using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanBreathing : MonoBehaviour
{
    public float oran;
    public void StartBreathing()
    {
        Debug.Log("Breathing");
        LeanTween.cancel(gameObject);
        gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f); 
        gameObject.LeanScale(new Vector3(oran, oran, oran), 0.7f).setLoopPingPong();
        
    }

     public void StopBreathing()
    {
        Debug.Log("Stopped Breathing");
        LeanTween.cancel(gameObject);  
    }
}
