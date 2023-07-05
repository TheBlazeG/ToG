using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        //if (isDashing)
        //{
        //    return;
        //}
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal")*Time.deltaTime*speed;
        change.y = Input.GetAxisRaw("Vertical")*Time.deltaTime*speed;
        Debug.Log(change);
        if (change != Vector3.zero)
        {

            transform.Translate(new Vector3(change.x, change.y));

        }
        MoveCharacter();
        //if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        //{
        //    StartCoroutine(Dash());
        //}
    }

    //private IEnumerator SecondAttackCo()
    //{
    //    //animator.SetBool("attacking", true);
    //    currentState = PlayerState.attack;
    //    yield return null;
    //    MakeArrow();
    //    //animator.SetBool("attacking", false);
    //    yield return new WaitForSeconds(.3f);
    //    if (currentState != PlayerState.interact)
    //    {
    //        currentState = PlayerState.walk;
    //    }
    //}

    //private void MakeArrow()
    //{
    //    if (playerInventory.currentMagic > 0)
    //    {
    //        Vector2 temp = new Vector2(animator.GetFloat("moveX"), animator.GetFloat("moveY"));
    //        Arrow arrow = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Arrow>();
    //        arrow.Setup(temp, ChooseArrowDirection());
    //        playerInventory.ReduceMagic(arrow.magicCost);
    //        reduceMagic.Raise();
    //    }
    //}

    //Vector3 ChooseArrowDirection()
    //{
    //    float temp = Mathf.Atan2(animator.GetFloat("moveY"), animator.GetFloat("moveX")) * Mathf.Rad2Deg;
    //    return new Vector3(0, 0, temp);
    //}
    //[Header("Dash Settings")]
    //[SerializeField] float dashSpeed = 20f;
    //[SerializeField] float dashDuration = .2f;
    //[SerializeField] float dashCooldown = 1f;
    //bool isDashing;
    //bool canDash=true;

    //private IEnumerator Dash()
    //{
    //    canDash = false;
    //    isDashing = true;
    //    rb.velocity = new Vector2(moveDirection.x * dashSpeed, moveDirection.y * dashSpeed);
    //    yield return new WaitForSeconds(dashDuration);
    //    isDashing = false;
    //    yield return new WaitForSeconds(dashCooldown);
    //    canDash = true;
    //}
    void MoveCharacter()
    {

        myRigidbody.MovePosition(transform.position + change.normalized * speed * Time.deltaTime
        );

    }
}
