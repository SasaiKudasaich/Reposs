using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

public class Movement : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Rigidbody2D rigid;
    public float speed = 5f;
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;


    void start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(UpKey) && transform.position.y < 3.45f)
        {
            rigid.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey) && transform.position.y > -3.45f)
        {
            rigid.velocity = Vector2.down * speed;
        }

        else
        {
            rigid.velocity = Vector2.zero;
        }

    }

}
