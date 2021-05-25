using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncoins : MonoBehaviour
{
    [SerializeField]
    public GameObject[] coins;
    [SerializeField]
    public float time = 3f;

    public int finishCount = 5;
    void Start()
    {
        StartCoroutine(SpawnCoins());
    }
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            if (LevelEnded.IsRestarted)
            {
                LevelEnded.IsRestarted = !LevelEnded.IsRestarted;
                MoneyText.Coin = 0;
            }
            Instantiate(coins[Random.Range(0, coins.Length - 1)],
                new Vector3(Random.Range(-7.5f, 7.5f), -5.5f, 0),
                Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    
}
