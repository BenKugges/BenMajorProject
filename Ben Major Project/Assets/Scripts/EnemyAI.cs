using UnityEngine.AI;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //This script makes the enemy AI patrol around the maze, to the waypoints that have been set//
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
   

    // Start is called before the first frame update
    void Start()
    {
        //This gets the NavMeshAgent component from the enemy, and records its original position//
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            //This finds the waypoint assigned, finds the shortest route to it then travels to that waypoint//
            IterateWaypointIndex();
            UpdateDestination();
        }


    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        //This function creates an index of the waypoints which are then used in void Update()//
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

   

}
