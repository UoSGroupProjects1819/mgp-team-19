using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorFoward : MonoBehaviour
{
    public GameObject lift;
    public float liftSpeed = 12f;
    public float maxDoorMove3d = 100f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            if (ElevatorBack.DoorMove3d >= -maxDoorMove3d)
            {
                lift.transform.Translate(Vector3.forward * (Time.deltaTime * liftSpeed));
                ElevatorBack.DoorMove3d -= 1;
            }
        }
    }
}
