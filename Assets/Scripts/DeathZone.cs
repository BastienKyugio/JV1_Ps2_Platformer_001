using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour
{
    private Animator fadeSystem;
    public GameObject[] disabledObjects;
    public GameObject spawn;

    private void Awake()
    {
        fadeSystem = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
        disabledObjects = GameObject.FindGameObjectsWithTag("canDestroy");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            StartCoroutine(ReplacePlayer(collision));
            StartCoroutine(ReplaceObjects());

        }
    }

    private IEnumerator ReplaceObjects()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < disabledObjects.Length; i++)
        {
            disabledObjects[i].SetActive(true);
        }
    }

    private IEnumerator ReplacePlayer(Collider2D collision)
    {
        CharacterMovement.instance.enabled = false;
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(2f);
        collision.transform.position = spawn.transform.position;
        CharacterMovement.instance.enabled = true;


    }
}

