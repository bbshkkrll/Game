using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagger : MonoBehaviour
{
    private bool gameHasEnded = false;

    public float restartDelay = 0.3f;

    public GameObject compliteLevelUI;
    public void CompleteLevel()
    {
        compliteLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}