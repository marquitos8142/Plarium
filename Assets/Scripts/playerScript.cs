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
    public Animator anim;

    private AudioSource SonidodDeSalto;

    private void Start()
    {
        SonidodDeSalto = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

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
            //rb.AddForce(new Vector2(-speedForce, 0), ForceMode2D.Impulse);
            transform.Translate(Vector3.left * speedForce * Time.deltaTime);
            


        }

        if (isRight)
        {
            //rb.AddForce(new Vector2(speedForce, 0), ForceMode2D.Impulse);
            transform.Translate(Vector3.right * speedForce * Time.deltaTime);
            

        }

        if (isJump && canJump)
        {

            isJump = false;
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
            Invoke("waitToJump", waitJump);
            SonidodDeSalto.Play();
            anim.SetTrigger("jump");
            Debug.Log("saltando");

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.GetComponent<Piso>())
        {
            canJump = true;
        }
    }
}
