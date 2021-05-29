using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagger : MonoBehaviour
{
    public GameObject compliteLevelUI;
    public GameObject restartLevelUI;

    public void CompleteLevel()
    {
        compliteLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void EndGame()
    {
        restartLevelUI.SetActive(true);
    }
}