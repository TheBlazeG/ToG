using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    private float moveSpeed;
    private bool moveRight;
    private bool start = true;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (start) 
        { 
            new WaitForSeconds(5f);
            start = false;
        }
        if (!start)
        {
            if (transform.position.x > 4f)
            {
                moveRight = false;
            }
            else if (transform.position.x < -4f)
            {
                moveRight = true;
            }
            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);

            }
            else
            {
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            }
        }
    }
}
