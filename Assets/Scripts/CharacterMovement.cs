using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isJumping;
    public bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask collisionLayers;
    public CapsuleCollider2D playercollider;
    public Animator animator;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    public SpriteRenderer spriteRenderer;
    private float horizontalMovement;
    private bool isFacingLeft = true;
    [SerializeField] private LayerMask groundLayer;

    //Bullet Variables
    [SerializeField] private GameObject darts;
    [SerializeField] private Transform firingPoint1;


    [SerializeField] private float shootPos;
    public bool rangeWeaponPick = false;

    public AudioClip manJumpingSound;
    public AudioClip jumpOnGrass;
    public AudioClip runOnGrass;

    public static CharacterMovement instance;



    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de CharacterMovement dans la scène");
            return;
        }
        instance = this;
    }
    void Update()
    {


        horizontalMovement = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            AudioManager.instance.PlayClipAt(manJumpingSound, transform.position);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            AudioManager.instance.PlayClipAt(jumpOnGrass, transform.position);
        }


        Flip();

        if (Input.GetKeyDown(KeyCode.Mouse0) && rangeWeaponPick && isGrounded)
        {
            Shoot();
            Debug.Log("appuye tireer ");
        }


        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMovement * moveSpeed, rb.velocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Shoot()
    {
        Instantiate(darts, firingPoint1.position, firingPoint1.rotation);
        Debug.Log("tireer ");
    }

    private void Flip()
    {
        if (!isFacingLeft && horizontalMovement < 0f || isFacingLeft && horizontalMovement > 0f)
        {
            isFacingLeft = !isFacingLeft;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
