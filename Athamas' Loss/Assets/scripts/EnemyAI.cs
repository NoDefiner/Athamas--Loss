using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using Unity.VisualScripting;

public class EnemyAI : MonoBehaviour
{

    public float speed = 2f;
    public float nextWaypointDistance = 3f;

    public Transform enemyGFX;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndPath = false;

    Seeker seeker;
    GameObject targetObject;
    Transform target;

    CircleCollider2D playerDetect;
    public EnemyAnimationSwitch animationSwitch;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        targetObject = GameObject.Find("player");
        // target = targetObject.transform;
        playerDetect = GetComponent<CircleCollider2D>();

        InvokeRepeating("UpdatePath", 0f, 0.9f);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player"))
        {
            target = targetObject.transform;
            animationSwitch.ChaseStart();
        }
    }

    void UpdatePath()
    {
        if (target == null) return;
        if (seeker.IsDone())
            seeker.StartPath(transform.position, target.position, OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
            return;
        
        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndPath = true;
            return;
        }
        else
        {
            reachedEndPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - (Vector2)transform.position).normalized;
        transform.Translate(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime, 0f);

        float distance = Vector2.Distance(transform.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }

        if (direction.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (direction.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
