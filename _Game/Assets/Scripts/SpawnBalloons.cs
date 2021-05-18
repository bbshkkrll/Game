using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    public GameObject[] RedBalloons;
    public GameObject[] YellowBalloons;
    private float[] positions = {-8f, -6f, -4f, -1f, 0, 1f, 3f, 5f, 7f, 8f};
    public float time = 9f;
    public int finishCount = 5;
    public float spawnRate = 0.1f;
    public float nextSpawnTime = 0f;
    private int yor = 0;

    void Update()
    {
        if(Time.time >= nextSpawnTime)
            if (yor % 5 != 0)
            {
                StartCoroutine(SpawnRedBalloons(RedBalloons));
                nextSpawnTime = Time.time + 1f / spawnRate;
                yor++;
            }
            else
            {
                StartCoroutine(SpawnRedBalloons(YellowBalloons));
                nextSpawnTime = Time.time + 1f / spawnRate;
                yor++;
            }
    }

    IEnumerator SpawnRedBalloons(GameObject[] balloons)
    {
        while (MoneyText.Coin < finishCount)
        {
            Instantiate(balloons[Random.Range(0, balloons.Length - 1)],
                new Vector3(positions[Random.Range(0, positions.Length - 1)], -5.5f, 0),
                Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}