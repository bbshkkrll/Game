using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagger : MonoBehaviour
{
   // private bool gameHasEnded = false;

    //public float restartDelay = 0.1f;

    public GameObject compliteLevelUI;
    public GameObject restartLevelUI;

    public void CompleteLevel()
    {
        compliteLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // ReSharper disable Unity.PerformanceAnalysis
    public void EndGame()
    {
        restartLevelUI.SetActive(true);
        //Time.timeScale = 0f;
    }
}