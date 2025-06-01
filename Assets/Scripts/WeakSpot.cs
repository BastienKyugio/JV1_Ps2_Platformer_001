using UnityEngine;

public class Weakspot : MonoBehaviour
{
    public GameObject objectToDestroy;
    private int hp = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Projectile"))
        {
            DamageDistance();
        }
    }
    public void DamageDistance()
    {
        if (hp <= 0)
        {
            Destroy(objectToDestroy);
        }
        else
        {
            hp--;
        }
    }
}
