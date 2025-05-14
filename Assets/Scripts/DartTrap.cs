using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTrap : MonoBehaviour
{
    [SerializeField] private GameObject projectiles;
    [SerializeField] private Transform firingPoint;
    [SerializeField] private float shootPos;
    //[Range(0.1f, 1f)]
    //[SerializeField] private float firerate = 1f;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
           Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(projectiles, firingPoint.position, firingPoint.rotation);
    }
}
