using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject posTteleport;
    public GameObject player;
    public bool isInRange = false;
    public AudioClip tpSound;

    private void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            Tp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isInRange = true;
        }    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            isInRange = false;
        }
    }
    private void Tp()
    {
        AudioManager.instance.PlayClipAt(tpSound, transform.position);
        player.transform.position = posTteleport.transform.position;
    }
}
