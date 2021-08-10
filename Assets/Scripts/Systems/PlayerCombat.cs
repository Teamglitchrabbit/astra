using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Transform attackpoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        // Play an attack animation


        // Detect enemies that are in range of the attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackpoint.position, attackRange, enemyLayers);

        // Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("we hit " + enemy.name);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackpoint == null)
            return;

        Gizmos.DrawWireSphere(attackpoint.position, attackRange);
    }

}
