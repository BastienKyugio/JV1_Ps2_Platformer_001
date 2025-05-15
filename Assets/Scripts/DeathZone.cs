using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
    private Animator fadeSystem;

    private void Awake()
    {
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            StartCoroutine(ReplacePlayer(collision));
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision)
    {
        CharacterMovement.instance.enabled = false;
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(2f);
        collision.transform.position = CurrentSceneManager.instance.respawnPoint;
        CharacterMovement.instance.enabled = true;

    }
}

