using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour
{
    public float thrust;
    public float knockTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("Player"))
        {
         Rigidbody2D hit =collision.GetComponent<Rigidbody2D>();
            if (hit != null) 
            {
                if (collision.gameObject.CompareTag("enemy"))
                {
hit.GetComponent<Enemy>().currentstate = EnemyState.stagger;
                }
                Vector2 difference = hit.transform.position - transform.position;
                difference=difference.normalized*thrust;
                hit.AddForce(difference, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(hit));
            }
        }
        if (collision.gameObject.CompareTag("breakable"))
        {
            collision.GetComponent<Switch>().Smash();

        }
    }
    private IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if (enemy != null)
        {
            yield return new WaitForSeconds(knockTime);
            enemy.velocity = Vector2.zero;
            enemy.GetComponent<Enemy>().currentstate = EnemyState.idle;

        }
    }
}
