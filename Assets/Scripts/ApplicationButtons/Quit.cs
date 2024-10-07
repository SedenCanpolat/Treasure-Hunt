using UnityEngine;
using UnityEngine.SceneManagement;


public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame");
        LevelManagement.instance.ChangeLevelWithTransition(0);
        //SceneManager.LoadScene(0);

    }
}
