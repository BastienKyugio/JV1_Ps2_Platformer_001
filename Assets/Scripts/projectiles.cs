using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectiles : MonoBehaviour
{

    public int damageOnCollision = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnCollision);
        }
    }
}
