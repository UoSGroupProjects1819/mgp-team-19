using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerCheck = 0;

    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject cam1;
    public GameObject cam2;

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
            cam1.SetActive(true);
            cam2.SetActive(false);

        }
        else if (playerCheck == 1)
        {
            PlayerOne.GetComponent<PlayerMovement>().enabled = false;
            PlayerTwo.GetComponent<PlayerMovement>().enabled = true;
            cam1.SetActive(false);
            cam2.SetActive(true);
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
