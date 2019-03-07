using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBack : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;
    public float maxDoorMove3d = 100f;
    public static int DoorMove3d = 0;
    public GameObject me;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (DoorMove3d <= maxDoorMove3d)
            {
                lift.transform.Translate(Vector3.back * (Time.deltaTime * liftSpeed));
                DoorMove3d += 1;
            }
        }
    }

}
