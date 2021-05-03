using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncoins : MonoBehaviour
{
    [SerializeField]
    public GameObject[] coins;
    [SerializeField]
    public float time = 3f;
    void Start()
    {
        StartCoroutine(SpawnCoins());
    }
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            Instantiate(coins[Random.Range(0, coins.Length - 1)],
                new Vector3(Random.Range(-8f, 8f), -5.5f, 0),
                Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }

    void Update()
    {

    }
}
