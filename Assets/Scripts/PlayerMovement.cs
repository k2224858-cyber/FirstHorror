using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        SetAnim();
    }

    void FixedUpdate()
    {
        rb.velocity = moveInput * moveSpeed * Time.fixedDeltaTime;
    }

    private void SetAnim()
    {
        animator.SetBool("Walk", rb.velocity.x != 0 || rb.velocity.y != 0);
    }
}
