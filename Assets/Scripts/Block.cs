using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public bool isOn;
    public OnOffController switchController;
    private Collider2D col;
    private Animator redswitch;
    


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        redswitch = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
            isOn = switchController.isOn;

            if (isOn)
            {
                redswitch.SetBool("upred", true);
                col.enabled = true;
            }
            else if (!isOn)
            {
                redswitch.SetBool("upred", false);
                col.enabled = false;
            }
        
        
    }
}
