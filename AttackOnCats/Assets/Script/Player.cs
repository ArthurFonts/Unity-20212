using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 7f;
    private Rigidbody2D rb;
    private Vector2 direction = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(Input.GetAxisRaw("Horizontal"));
    }

    void Move(float move)
    {
        if (move > 0)
            direction = Vector2.right;
        if (move < 0)
            direction = Vector2.left;

        rb.velocity = new Vector2(direction.x * velocidade, rb.velocity.y);

        if (move == 0)
            rb.velocity = new Vector2(0, rb.velocity.y);

        transform.right = direction;
    }
}
