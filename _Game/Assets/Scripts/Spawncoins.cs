using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawncoins : MonoBehaviour
{
    [SerializeField]
    private GameObject coins;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    //public float time = 0.75f;
    private float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {
        //StartCoroutine(SpawnCoins());
    }
  /*  IEnumerator SpawnCoins()
    {
        while (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(coins, whereToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }*/

    //нахуевертил сам хз чего, починю 4 мая вечером, чмок
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            RandX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            Instantiate(coins, whereToSpawn, Quaternion.identity);
            
        }
    }
}
