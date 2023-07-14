/***
using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    //variables
    [SerializeField] private float dashTime;
    [SerializeField] private float dashvelocity;
    [SerializeField] private float dashcouldown;
    [SerializeField] public bool isDashing;
    [SerializeField] private bool canDash;

    Rigidbody2D rb2d;
    PlayerMovement pm;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        pm = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown("Dash"))
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        if(pm.direction != Vector2.zero && canDash)
        {
            isDashing = true;
            canDash = false;
            rb2d.velocity = pm.direction * dashvelocity;
            yield return new WaitForSeconds(dashTime);
            isDashing = false;
            yield return new WaitForSeconds(dashcouldown);
            canDash = true;
        }
    }
}
*/