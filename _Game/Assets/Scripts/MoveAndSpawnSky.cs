using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndSpawnSky : MonoBehaviour
{
    public GameObject[] sky;
    public float time = 10f;
    public int finishCount = 5;

    void Start()
    {
        StartCoroutine(SpawnRedBalloons());
    }

    IEnumerator SpawnRedBalloons()
    {
        while (true)
        {
            Instantiate(sky[Random.Range(0, sky.Length - 1)],
                    new Vector3(0, -10f, 0),
                    Quaternion.identity);
                yield return new WaitForSeconds(time);
            
        }
    }
}