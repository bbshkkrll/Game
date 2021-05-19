using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    void Update()
    {
        if (transform.position.y > 5.5f)
        {
            gameObject.SetActive(false);
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
