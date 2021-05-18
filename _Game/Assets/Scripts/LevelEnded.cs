using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnded : MonoBehaviour
{
    public static bool IsRestarted = false;
    public void RestartLevel()
    {
        ResetLevel(1);
    }

    public void GetMenu()
    {
        ResetLevel(0);
    }

    private static void ResetLevel(int sceneIndex)
    {
        Time.timeScale = 1f;
        IsRestarted = true; 
        BalloonsText.ResetCount(); 
        MoneyText.ResetCount(); 
        SceneManager.LoadScene(sceneIndex);
        MoveSky.isFinishNotSpawned = true;
        EndTrigger.time = 3.5f;
        EndTrigger.isContacted = false;
    }
}
