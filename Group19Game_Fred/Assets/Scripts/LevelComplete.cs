using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public string player;
    public string SceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().SwitchPlayer();
        }

        if (other.gameObject.tag == "SecondPlayer")
        {
            SceneManager.LoadScene(SceneToLoad);
            GameObject.Find("GameManager").GetComponent<GameManager>().SwitchPlayer();
        }

        if (other.gameObject.tag == player)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
