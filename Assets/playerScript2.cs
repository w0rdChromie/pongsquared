using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript2 : MonoBehaviour
{
    public float speed2;
    public Rigidbody2D rb;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed2);
    }
}
