using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{

    public static DontDestroy instance;
    public static int lastsaved;

    void Start()
    {

        if (instance != null)
        {
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }



    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
