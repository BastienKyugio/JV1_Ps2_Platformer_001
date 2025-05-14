using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBreak : MonoBehaviour
{
    public GameObject objectToDestroy;
    public BoxCollider2D _collider;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Debug.Log("ouaiss");
            StartCoroutine(Breaking());
        }
    }
    private IEnumerator Breaking()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(objectToDestroy);
    }
}
