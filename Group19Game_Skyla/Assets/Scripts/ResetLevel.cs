using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public string SceneToLoad;

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
