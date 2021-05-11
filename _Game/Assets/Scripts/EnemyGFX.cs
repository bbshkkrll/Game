using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    //public GameObject bird;
    void Update()
    {
        if (transform.position.y > 5.5f)
        {
            gameObject.SetActive(false);
            /*Instantiate(bird, new Vector2(Random.Range(-8f, 8f), -5f), Quaternion.identity);*/
        }
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
