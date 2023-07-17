using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2 : MonoBehaviour
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
            redswitch.SetBool("upblue", false);
            col.enabled = false;
        }
        else if (!isOn)
        {
            redswitch.SetBool("upblue", true);
            col.enabled = true;
        }
    }
}
