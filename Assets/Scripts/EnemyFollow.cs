using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed = 0.5f;
    public Transform player;
    public BoxCollider2D targetCollider;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {


            Vector3 displacement = player.position - transform.position;
            displacement = displacement.normalized;

            if (Vector2.Distance(player.position, transform.position) > 1.0f)
            {
                transform.Translate(displacement * speed * Time.deltaTime, Space.World);

            }
            else
            {
                //hit
            }
        }
    }
}