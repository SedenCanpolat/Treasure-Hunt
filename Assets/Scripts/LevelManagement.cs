using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour // sigleton YAP
{
    public int sceneCount = 1;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLevelWithTransition(){ 
        FindObjectOfType<GeneralTransition>().MakeTransition(ChangeLevel);
    }

    public void ChangeLevel(){
        SceneManager.LoadScene(sceneCount);
    }


}
