using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    public GameObject[] RedBalloons;
    public GameObject[] YellowBalloons;

    public float time = 2f;
    private int yor = 0;
    public static bool isSpawnerCalled = false;

    void Start()
    {
        StartCoroutine(SpawnRedBalloons(RedBalloons, YellowBalloons));
    }

    IEnumerator SpawnRedBalloons(GameObject[] red, GameObject[] yellow)
    {
        while (true)
        {
            if (yor % 5 != 0)
                CreateObjects(red);
            else
                CreateObjects(yellow);

            yor++;
            yield return new WaitForSeconds(time);
        }
    }
    public void CreateObjects(GameObject[] balloons) 
        => Instantiate(balloons[0],
           new Vector3(Random.Range(-7.5f, 7.5f), -5.5f, 0),
           Quaternion.identity);
}