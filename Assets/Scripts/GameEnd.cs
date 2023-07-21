using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (col.enabled==false)
        {
            SceneManager.LoadScene(DontDestroy.lastsaved);
        }
    }
}
