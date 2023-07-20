using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetLevelOne : MonoBehaviour
{
    [SerializeField] DontDestroy dd;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroy.lastsaved = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
