using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    bool isLeft = false;
    bool isRight = false;
    bool isJump = false;
    bool canJump = true;

    public Rigidbody2D rb;
    public float speedForce;
    public float jumpForce;
    public float waitJump;

    public void clickLeft()
    {
        isLeft = true;
    }

    public void releaseLeft()
    {
        isLeft = false;
    }

    public void clickRight()
    {
        isRight = true;
    }

    public void releaseRight()
    {
        isRight = false;
    }

    public void clickJump()
    {
        isJump = true;
    }

    private void FixedUpdate()
    {
        if (isLeft)
        {
            rb.AddForce(new Vector2(-speedForce, 0),  ForceMode2D.Impulse);
        }

        if (isRight)
        {
            rb.AddForce(new Vector2(speedForce, 0),  ForceMode2D.Impulse);
        }

        if (isJump && canJump)
        {
            isJump = false;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
            Invoke("waitToJump", waitJump);
        }
    }

    void waitToJump()
    {
        canJump = true;
    }
}
