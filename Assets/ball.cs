using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed = 6f;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        RandomBallDir();
    }

    private void RandomBallDir()
    {
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;

        Vector2 newBallvect = new Vector2();
        newBallvect.x = Random.Range(-1f, 1f);
        newBallvect.y = Random.Range(-1f, 1f);
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
            Debug.Log("Player Left +1");
        }
        else
        {
            Debug.Log("Player Right +1");
        }
        
        RandomBallDir();

    }
}
