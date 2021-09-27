using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb2d;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
         }
        rb2d.velocity = new Vector2(rb2d.velocity.x, movement * speed);
    }
}
