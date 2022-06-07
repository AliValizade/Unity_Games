using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public float speed = 20;
    public float force = 5;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        player.velocity = new Vector2(x*speed,player.velocity.y);

        if(Input.GetKeyDown(KeyCode.UpArrow))
       player.velocity += Vector2.up*force;
    
        
    }
}
