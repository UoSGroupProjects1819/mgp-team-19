using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerCheck = 0;

    public GameObject PlayerOne;
    public GameObject PlayerTwo;

    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SwitchPlayer();
        }

        if(playerCheck == 0)
        {
            PlayerOne.GetComponent<PlayerMovement>().enabled = true;
            PlayerTwo.GetComponent<PlayerMovement>().enabled = false;
        }
        else if (playerCheck == 1)
        {
            PlayerOne.GetComponent<PlayerMovement>().enabled = false;
            PlayerTwo.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    public void SwitchPlayer()
    {
        if (playerCheck == 0)
        {
            playerCheck = 1;
        }
        else if (playerCheck == 1)
        {
            playerCheck = 0;
        }
    }

}
