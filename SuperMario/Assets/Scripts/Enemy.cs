using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public GameObject mario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        
    }
    void OnCollisionEnter2D(Collision2D mario)
    {
        if(mario.gameObject.name.StartsWith("mario"))
        {
            Destroy(mario.gameObject);
        }
    }
}
