using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;

    private void Start () {
        rb = GetComponent<Rigidbody2D> ();
    }

    private void Update () {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;
    }

    private  void FixedUpdate () {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
