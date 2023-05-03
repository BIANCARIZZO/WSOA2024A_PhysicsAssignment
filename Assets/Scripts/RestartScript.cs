using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public void QuitGame()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("CountdownScene");
    }

}
