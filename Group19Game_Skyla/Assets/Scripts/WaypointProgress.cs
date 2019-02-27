using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointProgress : MonoBehaviour
{
    private Transform cam;
    public float sqrMag;
    public float closestDistanceSqr;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindWithTag("CinematicCam").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curpos = transform.position;
        closestDistanceSqr = Mathf.Infinity;
        Vector3 distTarg = cam.position - curpos;
        sqrMag = distTarg.sqrMagnitude;
        if(sqrMag < curpos.sqrMagnitude)
        {
            GameObject.FindWithTag("CinematicCam").GetComponent<Cinematic_Camera>().currentWaypoint++;
            Destroy(this.gameObject);
        }
    }
}
