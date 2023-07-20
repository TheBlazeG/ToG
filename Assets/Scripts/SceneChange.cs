using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private Collider2D col;
    [SerializeField] DontDestroy dd;

    // Start is called before the first frame update

    private void Start()
    {
        col = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DontDestroy.lastsaved = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(DontDestroy.lastsaved);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
