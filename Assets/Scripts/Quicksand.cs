using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quicksand : MonoBehaviour
{
    public Rigidbody2D rgbd;
    private float _moveSpeed;
    private float _jumpForce;


    
    private void Start()
    {
        _moveSpeed = CharacterMovement.instance.moveSpeed;
        _jumpForce = CharacterMovement.instance.jumpForce;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("player"))
        {
            CharacterMovement.instance.moveSpeed /= 3;
            CharacterMovement.instance.jumpForce /= 3;
            rgbd.mass = 2;
            rgbd.gravityScale = 0.1f;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            CharacterMovement.instance.moveSpeed = _moveSpeed;
            CharacterMovement.instance.jumpForce = _jumpForce;
            rgbd.mass = 1;
            rgbd.gravityScale = 1;

        }
    }
}
