using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;

public class Enemy_Knockback : MonoBehaviour
{
    private Rigidbody2D rb;
    private EnemyMovement enemyMovement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyMovement = GetComponent<EnemyMovement>();
    }

    public void Knockback(Transform playerTransform, float knockbackFroce,float knockbackTime ,float stunTime)
    {
        enemyMovement.ChangeState(EnemyState.Knockback);
        Vector2 direction = (transform.position - playerTransform.position).normalized;
        StartCoroutine(StunTimer(knockbackTime,stunTime));
        rb.velocity = direction * knockbackFroce;
        Debug.Log("knockback applied.");
    }

    IEnumerator StunTimer(float knockbackTime,float stunTime)
    {
        yield return new WaitForSeconds(knockbackTime);
        rb.velocity = Vector2.zero;
        yield return new WaitForSeconds(stunTime);
        enemyMovement.ChangeState(EnemyState.Idle);
    }
}
