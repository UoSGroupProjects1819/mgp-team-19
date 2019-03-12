using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public string SceneToLoad;
    public GameObject player;
    public GameObject player2;

    private void OnCollisionEnter(Collision collision)
    {
        //upon collision, resets the scene, and re-creates the players.

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "SecondPlayer")
        {
            SceneManager.LoadScene(SceneToLoad);
            player.SetActive(false);
            player2.SetActive(false);

        }
    }

}
