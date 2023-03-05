using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(rb.velocity.x, movespeed);
            sound.Play();
        }

        if (Input.touchCount > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movespeed);
        }
            foreach (Touch touch in Input.touches) {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
               
                sound.Play();
            }

            
        }

    }
}
