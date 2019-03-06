using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallRelease : MonoBehaviour
{
    public GameObject wreckingBall;
    public GameObject wreckingBallHolder;
    public float velocity;
    public FixedJoint fixedJoint;




    private void Update()
    {
        fixedJoint = GetComponent<FixedJoint>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wreckingBallHolder.SetActive(true);
            wreckingBall.SetActive(true);
        }

    }

}
