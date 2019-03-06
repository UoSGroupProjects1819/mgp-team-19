using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstantiate : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject camPrefab;
    public bool willSpawnPlayer = false;
    public GameObject CurPlayer;

    private void Update()
    {
        //checks if previous player is spawned, if false creates one, prevents multiple player chars
        if (CurPlayer == null && willSpawnPlayer == false)
        {
            CurPlayer = GameObject.FindWithTag("Player");
            willSpawnPlayer = true;
        }
        if (willSpawnPlayer == true && CurPlayer == null)
        {
            Instantiate(playerPrefab);
            Instantiate(camPrefab);
            willSpawnPlayer = false;
        }
    }
}
