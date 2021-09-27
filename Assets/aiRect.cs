using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiRect : playerScript
{

    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                rb2d.AddForce(Vector2.up * this.speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                rb2d.AddForce(Vector2.down * this.speed);
            }
        }
        else {
            if (this.transform.position.y > 0.0f) {
                rb2d.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f) {
                rb2d.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
