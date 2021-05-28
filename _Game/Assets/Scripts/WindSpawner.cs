using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawner : MonoBehaviour
{
        public GameObject[] winds;
        public float time = 3f;
        
        void Start()
        {
            StartCoroutine(SpawnWind());
        }
        IEnumerator SpawnWind()
        {
            while (true)
            {
                if (LevelEnded.IsRestarted)
                {
                    LevelEnded.IsRestarted = !LevelEnded.IsRestarted;
                    MoneyText.Coin = 0;
                }
                Instantiate(winds[Random.Range(0, winds.Length - 1)],
                    new Vector3(-11f, Random.Range(-3f,3f), 0),
                    Quaternion.identity);
                yield return new WaitForSeconds(time);
            }
        }
}
