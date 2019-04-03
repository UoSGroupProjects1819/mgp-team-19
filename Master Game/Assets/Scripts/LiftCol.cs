using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftCol : MonoBehaviour
{
    public bool no_down = false;
    public bool no_up = false;
    public bool no_left = false;
    public bool no_right = false;
    public bool no_foward = false;
    public bool no_back = false;

    public GameObject left_button;
    public GameObject right_button;
    public GameObject down_button;
    public GameObject up_button;
    public GameObject foward_button;
    public GameObject back_button;
    public float liftSpeed = 30f;
    public float maxDoorMoveHoriz = 100f;
    public float DoorMoveHoriz = 0;
    public float DoorMoveVert = 0;
    public float maxDoorMoveVert = 100f;
    public float DoorMove3D = 0;
    public float maxDoorMove3D = 100f;
    

    private void Update()
    {
        if (left_button.GetComponent<PlayerDetection>().player_hit_me == true && no_left == false)
        {
            Elevator_left();
        }
        if (right_button.GetComponent<PlayerDetection>().player_hit_me == true && no_right == false)
        {
            Elevator_right();
        }
        if (down_button.GetComponent<PlayerDetection>().player_hit_me == true && no_down == false)
        {
            Elevator_down();
        }
        if (up_button.GetComponent<PlayerDetection>().player_hit_me == true && no_up == false)
        {
            Elevator_up();
        }
        if (foward_button.GetComponent<PlayerDetection>().player_hit_me == true && no_foward == false)
        {
            Elevator_foward();
        }
        if (back_button.GetComponent<PlayerDetection>().player_hit_me == true && no_back == false)
        {
            Elevator_back();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (down_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_down = true;
                this.gameObject.transform.Translate(Vector3.up * (Time.deltaTime * 1));
            }
        }
        if (up_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_up = true;
                this.gameObject.transform.Translate(Vector3.down * (Time.deltaTime * 1));
            }
        }
        if (left_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_left = true;
                this.gameObject.transform.Translate(Vector3.right * (Time.deltaTime * 1));
                
            }
        }
        if (right_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_right = true;
                this.gameObject.transform.Translate(Vector3.left * (Time.deltaTime * 1));
            }
        }
        if (foward_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_foward = true;
                this.gameObject.transform.Translate(Vector3.back * (Time.deltaTime * 1));
            }
        }
        if (back_button.GetComponent<PlayerDetection>().player_hit_me == true)
        {
            if (other.gameObject.tag == "Floor")
            {
                no_back = true;
                this.gameObject.transform.Translate(Vector3.forward * (Time.deltaTime * 1));
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        no_down = false;
        no_up = false;
        no_left = false;
        no_right = false;        
        no_foward = false;
        no_back = false;
    }

    public void Elevator_left()
    {
        if (DoorMoveHoriz >= -maxDoorMoveHoriz)
        {
            this.gameObject.transform.Translate(Vector3.left * (Time.deltaTime * liftSpeed));
            DoorMoveHoriz -= 1;
        }
    }
    public void Elevator_right()
    {
        if (DoorMoveHoriz <= maxDoorMoveHoriz)
        {
            this.gameObject.transform.Translate(Vector3.right * (Time.deltaTime * liftSpeed));
            DoorMoveHoriz += 1;
        }
    }
    public void Elevator_down()
    {
        if (DoorMoveVert >= 0)
        {
            this.gameObject.transform.Translate(Vector3.down * (Time.deltaTime * liftSpeed));
            DoorMoveVert -= 1;
        }
    }
    public void Elevator_up()
    {
        if (DoorMoveVert <= (maxDoorMoveVert))
        {
            this.gameObject.transform.Translate(Vector3.up * (Time.deltaTime * liftSpeed));
            DoorMoveVert += 1;
        }
    }
    public void Elevator_foward()
    {
        if (DoorMove3D >= -maxDoorMove3D)
        {
            this.gameObject.transform.Translate(Vector3.forward * (Time.deltaTime * liftSpeed));
            DoorMove3D -= 1;
        }
    }
    public void Elevator_back()
    {
        if (DoorMove3D <= maxDoorMove3D)
        {
            this.gameObject.transform.Translate(Vector3.back * (Time.deltaTime * liftSpeed));
            DoorMove3D += 1;
        }
    }


}
