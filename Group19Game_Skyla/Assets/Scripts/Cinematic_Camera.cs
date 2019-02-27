using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Cinematic_Camera : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform target;
    private NavMeshAgent nav;
    public int currentWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GetClosestWaypoint(waypoints);
    }

    // Update is called once per frame
    void Update()
    {
        target = waypoints[currentWaypoint];

        nav.destination = target.position;

        foreach  (Transform point in waypoints)
        {
            if(point == null)
            {
                return; 
            }
        }
    }

    Transform GetClosestWaypoint(Transform[] MyWaypoints)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform potentialWaypoint in waypoints)
        {
            Vector3 dirToTarget = potentialWaypoint.position - currentPos;
            float dSqrToTarget = dirToTarget.sqrMagnitude;
            if(dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialWaypoint;
                Debug.Log(bestTarget);
            }
        }
        return bestTarget;
    }
}
