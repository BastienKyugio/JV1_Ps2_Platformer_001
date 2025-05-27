using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjet : MonoBehaviour
{
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Inventory.instance.AddFeathers(1);
            Destroy(gameObject);
            
        }
    }
}
