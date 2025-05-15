using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Inventory.instance.AddFeathers(1);
            Destroy(gameObject);
        }
    }
}
