using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnballoons : MonoBehaviour
{
    public GameObject[] balloons;
    private float[] positions = {-8f, -6f, -4f, -1f, 0, 1f, 3f, 5f, 7f, 8f};
    public float time = 1f;
    void Start()
    {
        StartCoroutine(SpawnRedBalloons());
    }
    IEnumerator SpawnRedBalloons()
    {
        while (true)
        {
            Instantiate(balloons[Random.Range(0,balloons.Length - 1)], 
                new Vector3(positions[Random.Range(0,positions.Length-1)],-5.5f,0),
                Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
    
    void Update()
    {
        
    }
}
