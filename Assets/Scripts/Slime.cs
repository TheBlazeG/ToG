using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Slime : Enemy
{
    private Rigidbody2D myRigidbody;
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        currentstate = EnemyState.idle;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ChangeDistance();
    }
    void ChangeDistance()
    {
        if (Vector3.Distance(target.position,transform.position)<=chaseRadius&& Vector3.Distance(target.position,transform.position)>attackRadius)
        {
            if (currentstate==EnemyState.idle ||currentstate==EnemyState.walk && currentstate!=EnemyState.stagger)
            {

            }
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position,moveSpeed*Time.deltaTime);
            myRigidbody.MovePosition(temp);
            ChangeState(EnemyState.walk);
        }
    }
    private void ChangeState(EnemyState newState)
    {
        if(currentstate!=newState) 
        {
            currentstate = newState;
        }
    }
}
