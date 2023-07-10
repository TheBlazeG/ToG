using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public bool isOn;
    public OnOffController switchController;
    private Collider2D col;


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isOn = switchController.isOn;

        if (isOn)
        {
            col.enabled = true;
        } else if (!isOn)
        {
            col.enabled = false;
        }
    }
}
