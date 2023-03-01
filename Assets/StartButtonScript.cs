using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public int sceneStarted;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneStarted);
    }
}
