using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Movement : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Rigidbody2D rigid;
    
        
    void start()
    {
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.velocity = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigid.velocity = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigid.velocity = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigid.velocity = Vector2.left;
        }
        else
        {
            rigid.velocity = Vector2.zero;
        }

    }

    private void OnMouseDown()
    {
        print("click");
        sprite.color = Color.black;
    }
}
