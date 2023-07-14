using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{

    public bool isOn;
    private GameObject child;
    public OnOffController switchController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isOn = switchController.isOn;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected!");

        if (collision.tag == "arrow")
        {
            Debug.Log("Collision arrow detected!");
            switchController.FlipSwitch();

            if (isOn)
            {

            } else if (!isOn)
            {

            }
        }
    }
}
