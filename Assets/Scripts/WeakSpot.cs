using UnityEngine;

public class Weakspot : MonoBehaviour
{
    public GameObject objectToDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Projectile"))
        {
            DamageDistance();
        }
    }
    public void DamageMelee()
    {
        Destroy(objectToDestroy);
    }
    public void DamageDistance()
    {
        Debug.Log("detruit");
        Destroy(objectToDestroy);
    }
}
