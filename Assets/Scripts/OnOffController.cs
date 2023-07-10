using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffController : MonoBehaviour
{

    public bool isOn;


    public void FlipSwitch()
    {
        isOn = !isOn;
    }
}
