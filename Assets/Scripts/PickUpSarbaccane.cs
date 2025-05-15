using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSarbaccane : MonoBehaviour
{

    public SpriteRenderer rangeWeapon;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            CharacterMovement.instance.rangeWeaponPick = true;
            rangeWeapon.enabled = true;
            Destroy(gameObject);
        }
    }
}
