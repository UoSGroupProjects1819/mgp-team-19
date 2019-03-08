using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public bool player_hit_me = false;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "SecondPlayer")
        {
            player_hit_me = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        player_hit_me = false;
    }
}
