using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Star : MonoBehaviour
{
    public Transform Transform;
    private Rigidbody2D RigidBody { get; set; }

    private const float Speed = 7f;
    private float MoveDirection { get; set; }

    private SpriteRenderer SpriteRenderer { get; set; }
    private Animator AnimatorComponent { get; set; }
    private GameManager Gm { get; set; }

    private void Awake()
    {
        Transform = GetComponent<Transform>();
        RigidBody = GetComponent<Rigidbody2D>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        AnimatorComponent = GetComponent<Animator>();
        Gm = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {
        MoveDirection = Input.GetAxis("Horizontal");

        if (MoveDirection > 0)
        {
            SpriteRenderer.flipX = false;
            // AnimatorComponent.SetInteger("state", 1);
        }
        else if (MoveDirection < 0)
        {
            SpriteRenderer.flipX = true;
            // AnimatorComponent.SetInteger("state", 1);
        }
        else
        {
            // AnimatorComponent.SetInteger("state", 0);
        }

        RigidBody.velocity = new Vector2(MoveDirection * Speed, RigidBody.velocity.y);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
    }
}