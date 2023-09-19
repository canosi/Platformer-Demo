#if UNITY_EDITOR
using UnityEditorInternal;
#endif

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class topTest : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    bool grounded;
    public float jump;
    public float max_speed = 8;
    public ScoreManager scoreManager;
   
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
       
        
        if(Input.GetKeyDown(KeyCode.Space) && grounded) 
        {   
            rb.AddForce(Vector2.up*jump,ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {   if(rb.velocity.x < max_speed)
            {
                rb.AddForce(new Vector2(speed, 0));
            }
            
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {   if(rb.velocity.x > -max_speed)
            {
                rb.AddForce(new Vector2(-speed, 0));
            }
            
        }


    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            scoreManager.AddPoint();
            Destroy(other.gameObject);
        }

    }
}