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
    [SerializeField]public int health;
    [SerializeField]public string enemyName;
    [SerializeField]public int baseAttack;
    [SerializeField] public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private IEnumerator KnockCo(Rigidbody2D myRigidbody,float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentstate = EnemyState.idle;
            myRigidbody.velocity= Vector2.zero;
        }
    }
    public void Knock(Rigidbody2D myRigidbody,float knockTime)
    {
        StartCoroutine(KnockCo(myRigidbody,knockTime));
    }
}
