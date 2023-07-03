using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onHit()
    {
        anim.SetBool("hit", true);
        StartCoroutine(SwitchCo());
    }
    IEnumerator SwitchCo()
    {
        yield return new WaitForSeconds(.3f);
        
    }
}
