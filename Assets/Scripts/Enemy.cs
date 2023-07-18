using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger
}

public class Enemy : MonoBehaviour
{
    public EnemyState currentstate;
    public FloatValue maxHealth;
    [SerializeField] public float health;
    [SerializeField] public string enemyName;
    [SerializeField] public int baseAttack;
    [SerializeField] public float moveSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        health = maxHealth.initialValue;
    }

    private void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentstate = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
        }
    }
    public void Knock(Rigidbody2D myRigidbody, float knockTime, float damage)
    {
        StartCoroutine(KnockCo(myRigidbody, knockTime, damage));
        TakeDamage(damage);
    }
}