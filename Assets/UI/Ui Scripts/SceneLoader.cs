using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    [SerializeField] DontDestroy dd;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(DontDestroy.lastsaved);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
