using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed = 6f;
    public UImanager UImanager;
    public float LeftPscore=0;
    public float RightPscore=0;
    public  static event Action BallReset;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        RandomBallDir();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.GetComponent<Rigidbody2D>() == null)
        {
            return;
        }
        collision.gameObject.GetComponent<Movement>().speed *= 1.1f;
        rigidbody2D.velocity *= 1.1f;

    }

    private void RandomBallDir()
    {
        BallReset?.Invoke();
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;

        Vector2 newBallvect = new Vector2();
        newBallvect.x = UnityEngine.Random.Range(-1f, 1f);
        newBallvect.y = UnityEngine.Random.Range(-1f, 1f);
        rigidbody2D.velocity = newBallvect.normalized * speed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            RandomBallDir();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0)
        {

            RightPscore += 1;
            UImanager.SetRightPlayerScoreText(RightPscore.ToString());


        }
        else
        {
            LeftPscore += 1;
            UImanager.SetLeftPlayerScoreText(LeftPscore.ToString());

        }


        RandomBallDir();

    }
}
