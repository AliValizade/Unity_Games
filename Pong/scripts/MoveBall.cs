using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;  
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D guest)
    {
        if(guest.gameObject.name == "Wallleft")
        {
            // The red team gets points.
        }
        if(guest.gameObject.name == "Wallright")
        {
            // The blue team gets points.            
        }
    }
}
