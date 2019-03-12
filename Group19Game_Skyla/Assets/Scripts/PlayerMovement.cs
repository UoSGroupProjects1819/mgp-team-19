using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    [Tooltip("Character Animation Handling")]
    private bool right;
    private bool left;
    private bool front;
    private bool back;
    public bool playerNum;
    public Transform cosmeticObj;
    public Animator anim;
    [Tooltip("Character speed as a float")]
    public float speed = 12f;
    public int player;
    private Rigidbody rb;
    public int rot;
    public bool will_rot = true;
    private void Start()
    {
        GameObject SpawnHalt = GameObject.Find("PlayerSetup");
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //rebunked movement system
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, -moveHorizontal);

        rb.AddForce(movement * speed);

        if(Input.GetKey(KeyCode.W))
        {
            right = false;
            left = false;
            front = false;
            back = false;
            if (rot != 90 && will_rot == true)
            {
                if(rot == 90)
                {
                    will_rot = false;
                    front = true;
                }
                rot++;
            }
            rb.MoveRotation(Quaternion.Euler(0, rot, 0));
            anim.SetBool("isRunning", true);
            
        }
        if(Input.GetKey(KeyCode.S))
        {
            if (rot != -90 && will_rot == true)
            {
                if (rot == -90)
                {
                    will_rot = false;
                    back = true;
                }
                rot--;
            }
            rb.MoveRotation(Quaternion.Euler(0, rot, 0));
            anim.SetBool("isRunning", true);
        }
        if(Input.GetKey(KeyCode.A))
        {
            if (rot != 0 && will_rot == true)
            {
                if (rot == 0)
                {
                    will_rot = false;
                    left = true;
                }
                rot--;
            }
            rb.MoveRotation(Quaternion.Euler(0, rot, 0));
            anim.SetBool("isRunning", true);
        }
        if(Input.GetKey(KeyCode.D))
        {
            if (rot != 180 && will_rot == true)
            {
                if (rot == 180)
                {
                    will_rot = false;
                    right = true;
                }
                rot++;
            }
            rb.MoveRotation(Quaternion.Euler(0, rot, 0));
            anim.SetBool("isRunning", true);
        }
        anim.SetBool("isRunning", false);
        //Mouse input for interaction
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Transform objectHit = hit.transform;
                Debug.Log("Hit " + objectHit);

                if (objectHit.gameObject.tag == "BoomCube")
                {
                    objectHit.GetComponent<Box_Damage>().health--;
                }
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "MovingPlatform" || collision.gameObject.tag == "Platform")
        {
            this.gameObject.transform.SetParent(collision.gameObject.transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.transform.SetParent(null);
        
    }
}
