using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target;

    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    public Transform EnemyGFX;
    
    private Path path;
    private int currentWayPoint = 0;

    private bool reachedEndOfPath = false;

    private Seeker seeker;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        
        InvokeRepeating("UpdatePath", 0f,.5f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, IsPathComplite);
    }
    void IsPathComplite(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWayPoint = 0;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
            return;

        if (currentWayPoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        reachedEndOfPath = false;

        var direction = ((Vector2) path.vectorPath[currentWayPoint] - rb.position).normalized;
        var force = direction * speed * Time.deltaTime;

        rb.AddForce(force);
        
        var distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]);

        if (distance < nextWaypointDistance)
        {
            currentWayPoint++;
        }

        if (force.x >= 0.01f)
            EnemyGFX.localScale = new Vector3(-1f, 1f, 1f);
        else if (force.x <= -0.01f) EnemyGFX.localScale = new Vector3(1f, 1f, 1f);
    }
}
