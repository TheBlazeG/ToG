using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int _index)
    {
        SceneManager.LoadScene(_index);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
