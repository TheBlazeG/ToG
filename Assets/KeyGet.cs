using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    private GameObject pp;
    public OnOffController switchController;
  
    
    // Start is called before the first frame update
    void Start()
    {
        pp = GetComponent<GameObject>();
     
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag=="Player")
        { 
            switchController.FlipSwitch();
        pp.SetActive(false);
        pp.GetComponent<SpriteRenderer>().enabled = false;    
        }
        
    }
}
