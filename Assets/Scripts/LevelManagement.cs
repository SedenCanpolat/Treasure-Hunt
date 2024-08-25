using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour 
{
    public static LevelManagement instance;
    private int _sceneIndex;


    private void Awake() {
        FindObjectOfType<GeneralTransition>().SceneChangend();
        if (instance != null && instance != this) 
        { 
            Destroy(this);
        } 
        else{ 
            instance = this; 
        } 
    }
    

    public void ChangeLevelWithTransition(int sceneIndex){ 
        _sceneIndex = sceneIndex;
        FindObjectOfType<GeneralTransition>().MakeTransition(ChangeLevel);
    }

    void ChangeLevel(){
        SceneManager.LoadScene(_sceneIndex);
    }


}
