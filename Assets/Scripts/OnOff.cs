using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{

    public bool isOn;
    private GameObject child;
    public OnOffController switchController;
    private Animator dungeonSwitch;

    // Start is called before the first frame update
    void Start()
    {
        dungeonSwitch = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isOn = switchController.isOn;
        if (isOn)
        {
            dungeonSwitch.SetBool("On", false);
        }
        else if (!isOn)
        {
            dungeonSwitch.SetBool("On", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected!");

        if (collision.tag == "arrow")
        {
            Debug.Log("Collision arrow detected!");
            
              
            
            

            switchController.FlipSwitch();

           
        }
    }
}
