using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallRelease : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;


    private void OnCollisionEnter(Collision collision)
    {
        //enbales specific component when collides with player.

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "SecondPlayer")
        {

            anim1.GetComponent<Animator>().enabled = true;
            anim2.GetComponent<Animator>().enabled = true;
            this.gameObject.SetActive(false);
        }
    }
}
