using UnityEngine;


public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        // FindObjectOfType<LevelManagement>().ChangeLevelWithTransition();
        Debug.Log("RestartGame");
        LevelManagement.instance.ChangeLevelWithTransition(0);
    }
}
