using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100;
    public GameObject Racket;
    public Vector3 start_game;

    // Start is called before the first frame update
    void Start()
    {
        start_game = transform.position;
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        float ball_y = transform.position.y;
        float Racket_y = Racket.transform.position.y;

        if(ball_y < Racket_y - 200)
        {
            transform.position = start_game;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        }
        
    }

    void OnCollisionEnter2D(Collision2D guest)
    {
        if(guest.gameObject.name == "Racket")
        {
            float ball_x = transform.position.x;
            float racket_x = guest.transform.position.x;
            float racket_w = guest.collider.bounds.size.x;
            //direction_x = 1  move to right
            //direction_x = -1  move to left
            //direction_x = 0  don't move
            float direction_x = (ball_x - racket_x) / racket_w;

            GetComponent<Rigidbody2D>().velocity = new Vector2(direction_x , 1) * speed;


        }
        else
        {
            //The ball collision to walls or blocks
        }
    }
}
