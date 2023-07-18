using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : Enemy
{
    private Rigidbody2D myRigidbody;
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        currentstate = EnemyState.idle;
        anim = GetComponent<Animator>();
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
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
                changeAnim(temp-transform.position);
                myRigidbody.MovePosition(temp);
                ChangeState(EnemyState.walk);
                anim.SetBool("moving", true);
            }
            else
            {
                anim.SetBool("moving", false);
            }
        }
    }
    private void SetAnimFloat(Vector2 setVector) 
    {
        anim.SetFloat("movex",setVector.x);
        anim.SetFloat("movey",setVector.y);
    }
    private void changeAnim(Vector2 direction) 
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x>0)
            {
                SetAnimFloat(Vector2.right);
            }
            else if (direction.x<0)
            {
                SetAnimFloat(Vector2.left);
            }
        }
        else if (Mathf.Abs(direction.x)<Mathf.Abs(direction.y))
        {
            if (direction.y > 0)
            {
                SetAnimFloat(Vector2.up);
            }
            else if (direction.y < 0)
            {
                SetAnimFloat(Vector2.down);
            }
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
