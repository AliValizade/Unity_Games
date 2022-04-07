using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public GameObject Food;

    public GameObject WallTop;
    public GameObject WallBottom;
    public GameObject WallRight;
    public GameObject WallLeft;

    public Vector2 direction = new Vector2(0, 0);
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        newApp();        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
            direction = Vector2.up;
            transform.rotation = Quaterion.Euler(0, 0, 180)
        else if(Input.GetKey(KeyCode.DownArrow))
            direction = - Vector2.up;
            transform.rotation = Quaterion.Euler(0, 0, 0)
        else if(Input.GetKey(KeyCode.RightArrow))
            direction = Vector2.right;
            transform.rotation = Quaterion.Euler(0, 0, 90)
        else if(Input.GetKey(KeyCode.LeftArrow))
            direction = - Vector2.right;
            transform.rotation = Quaterion.Euler(0, 0, -90)
        
        GetComponent<Rigidbody2D>().velocity = direction * speed;
                        
    }
    
    void newApp()
    {
        int x = (int)Random.Range(WallLeft.transform.position.x + 2, WallRight.transform.position.x - 2);
        int y = (int)Random.Range(WallBottom.transform.position.y + 2, WallTop.transform.position.y - 2);

        Instantiate(Food, 
                    new Vector2(x, y), 
                    Quaterion.Euler(0, 0, 0)); 
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.name.StartsWith("Apple"))
        {
            newApp();

            Debug.Log("Ummm, bah bah!");
        }
        else
        {
            Debug.Log("Game Over!");
            SceneManager.
        }
    }
}
