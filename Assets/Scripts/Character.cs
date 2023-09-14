using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private bool jump;
    private bool canjump = false;
    private Rigidbody2D _rigibody;
    private Animator _anim;
    private AudioSource SonidodDeSalto;

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private bool estaCorriendoAnim = false;
    [SerializeField] KeyCode teclaIzquierda;
    [SerializeField] KeyCode teclaDerecha;
    private void Start()
    {
        _rigibody = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        SonidodDeSalto = GetComponent<AudioSource>();

    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetKey(teclaIzquierda) || Input.GetKey(teclaDerecha))
        {
        estaCorriendoAnim = true;
        }
        else
        {
            estaCorriendoAnim = false;
        }

        //Debug.Log(movement);

        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        

        if (Input.GetButtonDown("Jump") )
        {
            if (canjump)
            {
                jump = true;
                canjump = false;
            }
                
        }
    }

    private void FixedUpdate()
    {
        if (jump )
        {
            jump = false;
            Debug.Log("salta");
            _rigibody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            _anim.SetTrigger("jump");
            SonidodDeSalto.Play();
          
        }
        if(estaCorriendoAnim)
        { 
        _anim.SetTrigger("correr");
        }
        else { _anim.SetTrigger("idle");
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Piso>())
        {
            canjump = true;
        }
        if (col.gameObject.GetComponent<Pegajoso>())
        {
            transform.SetParent(col.gameObject.transform);
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Piso>())
        {
            canjump = true;
        }
        if (col.gameObject.GetComponent<Pegajoso>())
        {
            transform.SetParent(null);
        }
    }
}